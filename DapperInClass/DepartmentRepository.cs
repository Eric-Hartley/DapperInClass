using Dapper;
using System;
using System.Collections.Generic;
using System.Data;

namespace DapperInClass
{
    internal class DepartmentRepository : IDepartmentRepository
    {
        private readonly IDbConnection _connection; //field

        public DepartmentRepository(IDbConnection connection)
        {
            _connection = connection;
        }
        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("SELECT * FROM Departments;"); //How to write SQL statement
        }
    }
}
