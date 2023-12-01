using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace p1c_fk
{
    public partial class Form2 : Form
    {
        string connectionString = "Server=localhost;Database=inlogproject_fk;Uid=root;Pwd=;";
        MySqlConnection connection;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Database verbonden");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database niet verbonden: " + ex.Message);
            }
        }

        private void submit_Click_1(object sender, EventArgs e)
        {
            string email = emailtxtBox.Text;
            string wachtwoord = PasswordTxtBox.Text;
            string voornaam = voornaamTxtBox.Text;
            string achternaam = AchternaamTxtBox.Text;
            string klas = KlasTxtBox.Text;

            try
            {
                if (string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(wachtwoord) ||
                    string.IsNullOrEmpty(voornaam) ||
                    string.IsNullOrEmpty(achternaam) ||
                    string.IsNullOrEmpty(klas))
                {
                    // Controleer of alle verplichte velden zijn ingevuld
                    MessageBox.Show("Vul alle verplichte velden in.");
                }
                else
                {   
                    string roleName = "gebruiker";
                    // een String om altijd 'gebruiker' in te voeren
                    string insertRoleSql = "INSERT INTO rol (naam) VALUES (@roleName);";

                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        using (MySqlCommand insertRoleCommand = new MySqlCommand(insertRoleSql, connection))
                        {
                            // Voeg de naam 'gebruiker' toe als parameter voor de SQL-query
                            insertRoleCommand.Parameters.AddWithValue("@roleName", roleName);
                            // Voer de SQL-query uit om de nieuwe rol toe te voegen
                            insertRoleCommand.ExecuteNonQuery();

                            // Het ID van de nieuwe rij in de tabel 'rol' ophalen
                            long roleId = insertRoleCommand.LastInsertedId;

                            // Nu kun je de nieuwe gebruiker aanmaken en het roleId gebruiken
                            string insertUserSql = "INSERT INTO gebruiker (email, wachtwoord, voornaam, achternaam, klas, rolid) " +
                                               "VALUES (@email, @wachtwoord, @voornaam, @achternaam, @klas, @roleId);";

                            using (MySqlCommand command = new MySqlCommand(insertUserSql, connection))
                            {
                                command.Parameters.AddWithValue("@email", email);
                                command.Parameters.AddWithValue("@wachtwoord", HashPassword(wachtwoord));
                                command.Parameters.AddWithValue("@voornaam", voornaam);
                                command.Parameters.AddWithValue("@achternaam", achternaam);
                                command.Parameters.AddWithValue("@klas", klas);
                                command.Parameters.AddWithValue("@roleId", roleId);
                                command.ExecuteNonQuery();
                            }

                            // Registratie voltooid
                            MessageBox.Show("Registratie voltooid.");
                            this.Hide();

                            // Een nieuw form maken
                            Form1 otherForm = new Form1();

                            // Het nieuwe formulier weergeven
                            otherForm.Show();
                        }
                    }
                }
            }
            catch (MySqlException sqlEx)
            {
                errorTxt.Text = "MySQL-fout: " + sqlEx.Message;
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
