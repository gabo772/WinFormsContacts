﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsContacts
{
    public class DataAccessLayer
    {
        

        private SqlConnection conn=new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WinFormsContacts;Data Source=DESKTOP-9JPBRRR\\MSSQLSERVER01");

        public void InsertContact(Contact contact) 
        {
            try
            {
                conn.Open();
                string query = @"
                                    INSERT INTO Contacts (FirstName, LastName, Phone, Address)
                                    VALUES(@FirstName,@LastName,@Phone,@Address)";
                SqlParameter firstName = new SqlParameter();
                firstName.ParameterName = "@FirstName";
                firstName.Value = contact.FirstName;
                firstName.DbType = System.Data.DbType.String;

                SqlParameter lastName = new SqlParameter("@LastName", contact.LastName);
                SqlParameter phone = new SqlParameter("@Phone", contact.Phone);
                SqlParameter address = new SqlParameter("@Address", contact.Address);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(firstName);
                command.Parameters.Add(lastName);
                command.Parameters.Add(phone);
                command.Parameters.Add(address);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                conn.Close();
            }
        }

        

    }
}
