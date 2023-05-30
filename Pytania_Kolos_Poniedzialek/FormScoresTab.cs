using System;
using System.Windows.Forms;

namespace Pytania_Kolos_Poniedzialek
{
    public partial class FormScoresTab : Form
    {
        DataClassesQuizDataContext db;
        int score;
        public FormScoresTab(int score, DataClassesQuizDataContext db)
        {
            InitializeComponent();
            this.db = db;
            this.score = score;
            labelScore.Text = score.ToString();
            fillList();
        }

        private void fillList()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Top user in db.Tops)
            {
                UserControlUserList ucl = new UserControlUserList(user);
                flowLayoutPanel1.Controls.Add(ucl);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            Top user = new Top
            {
                Nick = textBoxNickname.Text,
                Score = score
            };

            db.Tops.InsertOnSubmit(user);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

            buttonSubmit.Enabled = false;  
            fillList();
        }

        private void buttonRefreshList_Click(object sender, EventArgs e)
        {
            fillList();
        }

        private void FormScoresTab_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
