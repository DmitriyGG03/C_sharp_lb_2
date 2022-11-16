using Hostels;

namespace C_sharp_lb_2
{
    public partial class CreatingHostel : Form
    {
        bool tr1 = false, tr2 = false, tr3 = false, tr4 = false;

        public CreatingHostel()
        {
            InitializeComponent();
        }


        private void tb_1_TextChanged(object sender, EventArgs e)
        {
            if (Campus.switchImageString(((TextBox)sender).Text))
            {
                pb_1.ImageLocation = Campus.picOK;
                tr1 = true;
            }
            else
            {
                pb_1.ImageLocation = Campus.picDislike;
                tr1 = false;
            }
        }

        private void tb_hostelAddress_TextChanged(object sender, EventArgs e)
        {
            if (Campus.switchImageString(((TextBox)sender).Text))
            {
                pb_2.ImageLocation = Campus.picOK;
                tr2 = true;
            }
            else
            {
                pb_2.ImageLocation = Campus.picDislike;
                tr2 = false;
            }
        }

        private void tb_staffNumber_TextChanged(object sender, EventArgs e)
        {
            if (Campus.switchImageInt(((TextBox)sender).Text, out int num))
            {
                pb_3.ImageLocation = Campus.picOK;
                tr3 = true;
            }
            else
            {
                pb_3.ImageLocation = Campus.picDislike;
                tr3 = false;
            }
        }

        private void tb_roomsNumber_TextChanged(object sender, EventArgs e)
        {
            if (Campus.switchImageInt(((TextBox)sender).Text, out int num))
            {
                pb_4.ImageLocation = Campus.picOK;
                tr4 = true;
            }
            else
            {
                pb_4.ImageLocation = Campus.picDislike;
                tr4 = false;
            }
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            if (tr1 && tr2 && tr3 && tr4)
            {
                int ID = Campus.GetID();
                var newHostle = new Hostel(ID, tb_univName.Text, tb_hostelAddress.Text, Convert.ToInt32(tb_staffNumber.Text), Convert.ToInt32(tb_roomsNumber.Text));
                Campus.hostels.Add((Hostel)newHostle.Clone());
                if (Campus.hostels.Count == 0) MessageBox.Show("New hostel hasn`t been created!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    foreach (Hostel hostel in Campus.hostels)
                        if (hostel.ID == ID) MessageBox.Show($"Новий гуртожиток № {hostel.ID}, що відноситься до університету: {hostel.universityName}, розташований за адресою: " +
                            $"{hostel.hostelAddress}, з {hostel.StuffNumber} працівниками та {hostel.RoomsNumber} кімнатами був успішно створений. Його поточний прибуток становить: {hostel.hostelProfit} грн.",
                            "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                }
            }
            else
            {
                MessageBox.Show("Перевірте правильність введення даних!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
