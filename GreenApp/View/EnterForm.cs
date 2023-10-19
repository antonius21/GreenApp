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

            if (string.IsNullOrEmpty(userName)&& string.IsNullOrEmpty(userPassword))
            {
                for (int i=0; i<userData.Length;i++) 
                {
                    if (userData[i,0,0] == userName && userData[i,1,0] == userPassword ) 
                    { 
                        userRole = userData[i,0,2];
                        MessageBox.Show("Роль користувача:", userRole );
                    }
                }
            }
        } 
    }
}
