using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Dapper;
using MySqlConnector;
using Core.Interfaces;

namespace Infastructure.Repositories
{
    public class BaseRepository: IBaseRepository
    {
        /// <summary>
        /// created by: VXKHANH
        /// created date: 22/06/2021
        /// Lớp base kết nối với cơ sở dữ liệu
        /// </summary>
        private string connectionString = "User Id=root;Host=localhost;Character Set=utf8;password=Khanh2000;Database=freshfood";
        private IDbConnection dbConnection;

        public BaseRepository()
        {
            dbConnection = new MySqlConnection(connectionString);
        }

        /// <summary>
        /// Lấy toàn bộ dữ liệu
        /// </summary>
        /// <typeparam name="entity">đối tượng</typeparam>
        /// <returns>Danh sách toàn bổ dữ liệu trong bảng</returns>
        public IEnumerable<entity> GetAll<entity>()
        {
            string className = typeof(entity).Name;
            string procName = $"procGet{className}s";
            List<entity> list = dbConnection.Query<entity>(procName, commandType: CommandType.StoredProcedure).ToList();
            return list;
        }

        /// <summary>
        /// Lấy 1 bản ghi theo id
        /// </summary>
        /// <typeparam name="entity">Đối tượng</typeparam>
        /// <param name="id">id của đói tượng cần lấy</param>
        /// <returns></returns>
        public entity getById<entity>(Guid id)
        {
            string className = typeof(entity).Name;
            string procName = $"procGet{className}ById";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add($"@{className}Id", id.ToString());
            entity result = dbConnection.Query<entity>(procName, param:dynamicParameters, commandType:CommandType.StoredProcedure).FirstOrDefault();
            return result;
        }
        /// <summary>
        /// created date: 23/06/2021
        /// created by: VXKHANH
        /// </summary>
        /// <typeparam name="entity">Đối tượng</typeparam>
        /// <param name="param">Đối tượng chứa dữ liệu thêm mới</param>
        /// <returns>Số dòng thay đổi</returns>
        public int insertEntity<entity>(entity param)
        {
            string className = typeof(entity).Name;
            string procName = $"procInsert{className}";
            int result = dbConnection.Execute(procName, param: param, commandType: CommandType.StoredProcedure);
            return result;
        }

        /// <summary>
        /// created date: 23/06/2021
        /// created by: VXKHANH
        /// Cập nhật bản ghi
        /// </summary>
        /// <param name="param">Đối tượng chứa dữ liệu cần thay đổi</param>
        /// <returns>Sô dòng thay đổi</returns>
        public int updateEntity<entity>(entity param)
        {
            string className = typeof(entity).Name;
            string procName = $"procUpdate{className}";
            int result = dbConnection.Execute(procName, param: param, commandType: CommandType.StoredProcedure);
            return result;
        }

        /// <summary>
        /// created date: 22/06/2021
        /// created by: VXKHANH
        /// Hàm xóa 1 bản ghi
        /// </summary>
        /// <typeparam name="entity">Đối tượng</typeparam>
        /// <param name="id">Id của đối tượng cần xóa</param>
        /// <returns>Số dòng thay đổi</returns>
        public int deleteEntity<entity>(Guid id)
        {
            string className = typeof(entity).Name;
            string procName = $"procDelete{className}";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add($"@{className}Id", id.ToString());
            int result = dbConnection.Execute(procName, param: dynamicParameters, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
