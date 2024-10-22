using InventorySystem;
using System;
using System.Data.Common;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InventoryNUnit
{
    public class Tests: IDisposable
    {
        private DBUtil dBUtil = new DBUtil();
        SqlConnection Con = null;
        DataGridView dgvProduct = null;

        [SetUp]
        public void Setup()
        {
            string connect = DBConnection.Connection;
            Con = new SqlConnection(connect);
            dgvProduct = new DataGridView();
        }

        [Test]
        public void popularate_RowExistTest()
        {
           
            //Act
            var rowCount = dBUtil.popularate(Con, dgvProduct, "ProductTbl");

            //Assert
            Assert.GreaterOrEqual(rowCount, 1);
        }

        public void Dispose()
        {
            
        }
    }
}