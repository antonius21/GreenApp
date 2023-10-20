using GreenApp.Model;
using GreenApp.View;

namespace GreenApp
{
    public partial class EnterForm : Form
    {
      

        public EnterForm()
        {
            InitializeComponent();
            



        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            ModelView.EnterModelView enterModelView = new ModelView.EnterModelView();
            string userName = loginTextBox.Text;
            string userPassword = passwordTextBox.Text;
            enterModelView.Authorisation(userName,userPassword);
            this.Hide();
        }
    }
}
