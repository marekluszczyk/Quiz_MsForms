using System.Windows.Forms;

namespace Pytania_Kolos_Poniedzialek
{
    public partial class UserControlUserList : UserControl
    {
        public UserControlUserList(Top user)
        {
            InitializeComponent();
            labelNick.Text = user.Nick;
            labelScore.Text = user.Score.ToString();
        }
    }
}
