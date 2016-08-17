using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace database_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.PAYMENT' table. You can move, or remove it, as needed.
            this.pAYMENTTableAdapter.Fill(this.database1DataSet.PAYMENT);
            // TODO: This line of code loads data into the 'database1DataSet.ROOM' table. You can move, or remove it, as needed.
            this.rOOMTableAdapter.Fill(this.database1DataSet.ROOM);
            // TODO: This line of code loads data into the 'database1DataSet.SERIAL' table. You can move, or remove it, as needed.
            this.sERIALTableAdapter.Fill(this.database1DataSet.SERIAL);
            // TODO: This line of code loads data into the 'database1DataSet.PATIENT' table. You can move, or remove it, as needed.
            this.pATIENTTableAdapter.Fill(this.database1DataSet.PATIENT);
            

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::database_project.Properties.Settings.Default.Database1ConnectionString);
            try
            {
                string sql = "INSERT INTO PATIENT (Gender, DOB, F_Name, L_Name, Height, Weight, Phone, H_Phone) values ('"+txtGender.Text+"', '"+txt_Dob.Value+"','"+txtf_name.Text+"','"+txtl_name.Text+"','"+txtHeight.Text+"', '"+txtWeight.Text+"','"+txtPhone.Text+"', '"+txtH_phone.Text+"')";
                SqlCommand exesql = new SqlCommand(sql, cn);
                cn.Open();
                exesql.ExecuteNonQuery();

                MessageBox.Show("New Patient added in the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.pATIENTTableAdapter.Fill(this.database1DataSet.PATIENT);
            }

            catch(Exception ex)
            {
                MessageBox.Show("please check your Value" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cn.Close();
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtl_name.Text = "";
            txt_Dob.Text = "";
            txtf_name.Text = "";
            txtGender.Text = "";
            txtH_phone.Text = "";
            txtHeight.Text = "";

            txtPhone.Text = "";
            txtWeight.Text = "";
        }

        private void btn_doctor_add_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::database_project.Properties.Settings.Default.Database1ConnectionString);
            try
            {
                string sql = "INSERT INTO DOCTOR (Doctor_Id, Doctor_Name, Doctor_Dept) values (" +doctor_IdTextBox.Text+ ",'"+doctor_NameTextBox.Text+"','"+doctor_DeptTextBox.Text+"')";
                SqlCommand exesql = new SqlCommand(sql, cn);
                cn.Open();
                exesql.ExecuteNonQuery();

                MessageBox.Show("New Doctor added in the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                this.dOCTORTableAdapter.Fill(this.database1DataSet.DOCTOR);
            }

            catch (Exception ex)
            {
                MessageBox.Show("please check your Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cn.Close();
            }
        }

        private void btn_ref_Click(object sender, EventArgs e)
        {
            doctor_IdTextBox.Text = "";
            doctor_NameTextBox.Text = "";
            doctor_DeptTextBox.Text = "";
        }

        private void btn_serial_Click(object sender, EventArgs e)
        {
            int doc_i,pat_i;
            SqlConnection cn = new SqlConnection(global::database_project.Properties.Settings.Default.Database1ConnectionString);
            //SqlConnection cn2 = new SqlConnection(global::database_project.Properties.Settings.Default.Database1ConnectionString);
            //try
            //{
            //    string sql = "SELECT Doctor_Id FROM DOCTOR WHERE  Doctor_id = "+doctor_IdTextBox1.Text;
            //    //string sql1 = "SELECT Patient_Id FROM PATIENT WHERE Patient_Id =" + patient_IdTextBox.Text;
            //    SqlCommand exesql = new SqlCommand(sql, cn);
            //    //SqlCommand exe = new SqlCommand(sql1, cn);            
            //    cn.Open();
            //    SqlDataReader reader = exesql.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        string temp;
            //        temp = reader[0].ToString();
            //        doc_i = int.Parse(temp);
            //    }
            //    cn.Close();

            //    cn2.Open();
            //    string sql1 = "SELECT Patient_Id FROM PATIENT WHERE Patient_Id =" + patient_IdTextBox.Text;
            //    SqlCommand exe = new SqlCommand(sql1, cn2);
            //    SqlDataReader reader2 = exe.ExecuteReader();

            //    while(reader2.Read())
            //    {
            //        string temp;
            //        temp = reader[0].ToString();
            //        pat_i = int.Parse(temp);
            //    }

            //    cn2.Close();

            
             try
            {
                string sql = "INSERT INTO SERIAL (Doctor_Id, Patient_Id)  values ("+doctor_IdTextBox1.Text+","+patient_IdTextBox.Text+")";
                SqlCommand exesql = new SqlCommand(sql, cn);
                cn.Open();
                exesql.ExecuteNonQuery();

                MessageBox.Show("New serial added in the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.sERIALTableAdapter.Fill(this.database1DataSet.SERIAL);
            }

            catch (Exception ex)
            {
                MessageBox.Show("please check your Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cn.Close();
            }

             

        }

        private void book_room_click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::database_project.Properties.Settings.Default.Database1ConnectionString);
            try
            {
                string sql = "INSERT INTO ROOM (Room_Id, Patient_Id) values ("+room_IdTextBox.Text+","+patient_IdTextBox1.Text+")";
                SqlCommand exesql = new SqlCommand(sql, cn);
                cn.Open();
                exesql.ExecuteNonQuery();

                MessageBox.Show("New Room added in the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.rOOMTableAdapter.Fill(this.database1DataSet.ROOM);
            }

            catch (Exception ex)
            {
                MessageBox.Show("please check your Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cn.Close();
            }
        }

        private void pay_btn_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::database_project.Properties.Settings.Default.Database1ConnectionString);
            try
            {
                string sql = "INSERT INTO PAYMENT (Patient_Id, Date_Bill_Paid, Total_Amount) values ("+pay_txt_pat_id.Text+",'"+date_Bill_PaidDateTimePicker.Value+"',"+pay_txt_total_amount.Text+")";
                SqlCommand exesql = new SqlCommand(sql, cn);
                cn.Open();
                exesql.ExecuteNonQuery();

                MessageBox.Show("New Payment record added in the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.pAYMENTTableAdapter.Fill(this.database1DataSet.PAYMENT);
            }

            catch (Exception ex)
            {
                MessageBox.Show("please check your Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cn.Close();
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::database_project.Properties.Settings.Default.Database1ConnectionString);
            try
            {
                string sql = "UPDATE PATIENT SET Gender = '" + genderTextBox.Text + "', DOB =  '" + dOBDateTimePicker.Value + "', F_Name = '" + f_NameTextBox.Text + "', L_Name = '"+ l_NameTextBox.Text+"', Height ='"+heightTextBox.Text+"' , Weight = '"+weightTextBox.Text+"', Phone = '"+phoneTextBox.Text+"', H_Phone = '"+h_PhoneTextBox.Text+"' WHERE Patient_Id =" + patient_IdTextBox2.Text;
                SqlCommand exesql = new SqlCommand(sql, cn);
                cn.Open();
                exesql.ExecuteNonQuery();

                MessageBox.Show("Patient updated in the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.pATIENTTableAdapter.Fill(this.database1DataSet.PATIENT);
            }

            catch (Exception ex)
            {
                MessageBox.Show("please check your Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cn.Close();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::database_project.Properties.Settings.Default.Database1ConnectionString);
            try
            {
                string sql = "DELETE FROM PATIENT WHERE Patient_Id =" + txt_pat_delete.Text;
                SqlCommand exesql = new SqlCommand(sql, cn);
                cn.Open();
                exesql.ExecuteNonQuery();

                MessageBox.Show("Patient record deleted from the database", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.pATIENTTableAdapter.Fill(this.database1DataSet.PATIENT);
            }

            catch (Exception ex)
            {
                MessageBox.Show("please check your Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cn.Close();
            }

            txt_pat_delete.Text = "";
        }    

    }
}
