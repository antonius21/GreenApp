using GreenApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GreenApp.ModelView
{
    internal class EnterModelView
    {
        private Array InitialisationArray()
        {
            Model.Economist  economist = new Model.Economist();

            string[,,] userData = new string[4, 4, 4];

            userData[0, 0, 0] = "anton";
            userData[0, 1, 0] = "12345";
            userData[0, 2, 0] = "agronom";


            userData[1, 0, 0] = "ivan";
            userData[1, 1, 0] = "12345678";
            userData[1, 2, 0] = "mechanizator";

            userData[2, 0, 0] = "mukola";
            userData[2, 1, 0] = "54321";
            userData[2, 2, 0] = "economist";
            return userData;
        }
        public void Authorisation(string _login, string _password)
        {
            string [,,] users = (string[,,])InitialisationArray();
            if (_login.Length != 0 && _password.Length != 0)
            {
                for (int i = 0; i < users.Length; i++)
                {

                    if (users[i, 0, 0] == _login && users[i, 1, 0] == _password)
                    {
                        string userRole = users[i, 2, 0];
                        MessageBox.Show(userRole);
                        ScreenRole(userRole);
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
