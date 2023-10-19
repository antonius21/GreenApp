using GreenApp.Model;
using GreenApp.View;

namespace GreenApp
{
    public partial class EnterForm : Form
    {
        string[,,] userData = new string[4, 4, 4];

        public EnterForm()
        {
            InitializeComponent();
            userData[0, 0, 0] = "anton";
            userData[0, 1, 0] = "12345";
            userData[0, 2, 0] = "agronom";


            userData[1, 0, 0] = "ivan";
            userData[1, 1, 0] = "12345678";
            userData[1, 2, 0] = "mechanizator";

            userData[2, 0, 0] = "mukola";
            userData[2, 1, 0] = "54321";
            userData[2, 2, 0] = "economist";
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string userName = loginTextBox.Text;
            string userPassword = passwordTextBox.Text;
            string userRole = "";
            if (userName.Length != 0 && userPassword.Length != 0)
            {
                for (int i = 0; i<userData.Length;i++) 
                {

                    if (userData[i,0,0] == userName && userData[i,1,0] == userPassword ) 
                    { 
                        userRole = userData[i,2,0];
                        MessageBox.Show( userRole );
                        ScreenRole(userRole);
                        this.Hide();
                        break;
                        
                    }
                }
            }

            
        }
        private void ScreenRole(string role)
        {
            switch (role)
            {
                case "agronom":
                    View.ARM_Agronom ARM_Agronom = new View.ARM_Agronom();
                    ARM_Agronom.Show();
                    break;
                case "mechanisator":
                    View.ARM_Mechanisator ARM_Mechanisator = new View.ARM_Mechanisator();
                    ARM_Mechanisator.Show();
                    break;
                case "economist":
                    View.ARM_Economis ARM_Economist = new ARM_Economis();
                    ARM_Economist.Show();
                    break;
                default:
                    MessageBox.Show("Невідома роль користувача.");
                    break;
            } 
        }
           

    }
}
