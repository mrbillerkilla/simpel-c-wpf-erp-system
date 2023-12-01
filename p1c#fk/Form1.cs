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
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace p1c_fk
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Database=inlogproject_fk;Uid=root;Pwd=;";
        MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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

        private string SHA256Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                StringBuilder hashBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    hashBuilder.Append(hashBytes[i].ToString("x2"));
                }

                return hashBuilder.ToString();
            }
        }

        private bool inlog(string email, string password)
        {
            try
            {
                // Compute SHA-256 hash of the input password
                string hashedPassword = SHA256Hash(password);

                // SQL query
                string query = "SELECT id, email, wachtwoord FROM gebruiker WHERE email = @email";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@email", email);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string storedPassword = reader["wachtwoord"].ToString();

                        // Controleer of het opgegeven wachtwoord (hashed) overeenkomt met het opgeslagen wachtwoord
                        if (storedPassword == hashedPassword)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("fout met inloggen: " + ex.Message);
                return false;
            }
        }

        private string rollen(string email)
        {
            try
            {

                // SQL query om de rol op te halen op basis van e-mailadres
                string query = "SELECT r.naam AS rol_naam " +
                               "FROM gebruiker AS g " +
                               "JOIN rol AS r ON g.rolid = r.id " +
                               "WHERE g.email = @email";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@email", email);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Rol gevonden, haal de rolnaam op
                        return reader["rol_naam"].ToString();
                    }
                }

                // Rol niet gevonden
                return "Rol niet gevonden";
            }
            catch (Exception ex)
            {
                // Behandel eventuele fouten hier
                MessageBox.Show("Fout bij het ophalen van de rol: " + ex.Message);
                return "Fout bij het ophalen van de rol";
            }
        }
        private void colorchange(string rol)
        {
            try
            {
                // Controleert de rol en verandert de achtergrondkleur
                if (rol == "admin")
                {
                    this.BackColor = Color.LightGreen;
                }
                else if (rol == "gebruiker")
                {
                    this.BackColor = Color.LightBlue;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout is: " + ex);
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            // Textbox declareren en initialiseren
            string email = loginEmail.Text;
            string password = loginPassword.Text;

            // Als de textbox niet leeg is, wordt de volgende if-statement uitgevoerd
            if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                // Inlog functie wordt aangeroepen
                if (inlog(email, password))
                {
                    MessageBox.Show("Inloggen gelukt!");

                    // Na succesvol inloggen, haal de rol op en toon deze
                    string rol = rollen(email);
                    if (!string.IsNullOrEmpty(rol))
                    {
                        MessageBox.Show("Uw rol is: " + rol);

                        // Roep de functie aan om de achtergrondkleur te wijzigen op basis van de rol
                        colorchange(rol);

                        // Roep de functie aan om de gebruikersgegevens weer te geven
                        DisplayUserData();
                    }
                }
                else
                {
                    MessageBox.Show("Inloggen mislukt. Controleer uw gegevens.");
                }
            }
        }


        private void DisplayUserData()
        {
            try
            {

                // SQL-query om gebruikersgegevens op te halen, inclusief rol naam
                string query = "SELECT " +
                    "g.id AS gebruiker_id, " +
                    "g.email AS gebruiker_email, " +
                    "g.wachtwoord AS gebruiker_wachtwoord, " +
                    "g.voornaam AS gebruiker_voornaam, " +
                    "g.achternaam AS gebruiker_achternaam, " +
                    "g.klas AS gebruiker_klas, " +
                    "r.naam AS rol_naam " +
                    "FROM gebruiker AS g " +
                    "JOIN rol AS r ON g.rolid = r.id";

                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Voer de query uit en haal de resultaten op
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        // Maak een StringBuilder om de gegevens op te slaan
                        StringBuilder userDataText = new StringBuilder();

                        while (reader.Read())
                        {

                            // Voeg gebruikersgegevens toe aan de StringBuilder
                            userDataText.AppendLine("Email: " + reader["gebruiker_email"].ToString());
                            userDataText.AppendLine("Wachtwoord: " + reader["gebruiker_wachtwoord"].ToString());
                            userDataText.AppendLine("Voornaam: " + reader["gebruiker_voornaam"].ToString());
                            userDataText.AppendLine("Achternaam: " + reader["gebruiker_achternaam"].ToString());
                            userDataText.AppendLine("Klas: " + reader["gebruiker_klas"].ToString());
                            userDataText.AppendLine("Rol: " + reader["rol_naam"].ToString());
                            userDataText.AppendLine(); 
                        }

                        // De textboxt laat de gebruikers zien
                        rolgegevens.Text = userDataText.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Geen resultaten gevonden.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij het ophalen van gebruikersgegevens: " + ex.Message);
            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            // Huidige form verbergen
            this.Hide();

            // Een nieuw form maken
            Form2 otherForm = new Form2();

            // Het nieuwe formulier weergeven
            otherForm.Show();
        }
    }
}
