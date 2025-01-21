namespace Lab_Act_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        // This method will handle the ComboBox selection change event.
        private void comboBoxPages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Initial setup for the form
        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime date = calendar.SelectionStart;
            datetbx.Text = date.ToString();
        }

        private void datetbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void birthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedBirthDate = birthCalendar.SelectionStart;
            birthdatetbx.Text = selectedBirthDate.ToShortDateString();

            int age = CalculateAge(selectedBirthDate);
            agetbx.Text = age.ToString();

        }

        private int CalculateAge(DateTime birthdate)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthdate.Year;


            if (currentDate.Month < birthdate.Month || (currentDate.Month == birthdate.Month && currentDate.Day < birthdate.Day))
            {
                age--;
            }

            return age;
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            string name = "", address = "", city = "", province = "", code = "", gender;
            string date, birthdate, age = "", prefContact = "";
            string sakit = "", medicine = "";
            string pregnantStat, allergyStat, allergyDescription;
            string bmi, bmiWant;

            name = firstNametbx.Text + lastNametbx.Text;
            address = addressline1.Text + addressline2.Text;
            city = citytbx.Text;
            code = zipcodetbx.Text;
            date = datetbx.Text;
            birthdate = birthdatetbx.Text;
            province = provincetbx.Text;
            age = agetbx.Text;
            allergyDescription = allergyDesc.Text;
            bmi = bmiNumber.Text;
            bmiWant = bmiDesire.Text;

            //Gender
            if (rdnMale.Checked)
            {
                gender = rdnMale.Text;
            }
            else if (rdnFemale.Checked)
            {
                gender = rdnFemale.Text;
            }
            else
            {
                gender = rdnOthers.Text;
            }

            //Contact
            if (phcallcbox.Checked == true)
            {
                prefContact = phcallcbox.Text;
            }
            else if (phMsgchbox.Checked == true)
            {
                prefContact = phMsgchbox.Text;
            }
            else if (emailchbox.Checked == true)
            {
                prefContact = emailchbox.Text;
            }
            else
            {
                prefContact = otherchbox.Text;
            }

            //sakit
            if (hbpressure.Checked == true)
            {
                sakit = sakit + " " + hbpressure.Text;
            }
            if (diabetes1.Checked == true)
            {
                sakit = sakit + " " + diabetes1.Text;
            }
            if (diabetes2.Checked == true)
            {
                sakit = sakit + " " + diabetes2.Text;
            }
            if (gout.Checked == true)
            {
                sakit = sakit + " " + gout.Text;
            }

            //medicine
            if (diabetes.Checked == true)
            {
                medicine = medicine + " " + diabetes.Text;
            }
            if (highpressure.Checked == true)
            {
                medicine = medicine + " " + highpressure.Text;
            }
            if (highCholesterol.Checked == true)
            {
                medicine = medicine + " " + highCholesterol.Text;
            }
            if (thyroid.Checked == true)
            {
                medicine = medicine + " " + thyroid.Text;
            }
            if (lithium.Checked == true)
            {
                medicine = medicine + " " + lithium.Text;
            }
            if (coumadin.Checked == true)
            {
                medicine = medicine + " " + coumadin.Text;
            }

            //Pregnant
            if (pregnantYes.Checked)
            {
                pregnantStat = pregnantYes.Text;
            }
            else
            {
                pregnantStat = pregnantNo.Text;
            }

            //Allergy
            if (allergyYes.Checked)
            {
                allergyStat = allergyYes.Text;
            }
            else
            {
                allergyStat = allergyNo.Text;
            }


            name = firstNametbx.Text + lastNametbx.Text;
            address = addressline1.Text + addressline2.Text;
            city = citytbx.Text;
            code = zipcodetbx.Text;
            date = datetbx.Text;
            birthdate = birthdatetbx.Text;
            province = provincetbx.Text;
            age = agetbx.Text;
            allergyDescription = allergyDesc.Text;
            bmi = bmiNumber.Text;
            bmiWant = bmiDesire.Text;

            MessageBox.Show("Successfully Added Informations" + Environment.NewLine +
                Environment.NewLine + "Name: ", Name +
                Environment.NewLine + "Address: " + address +
                Environment.NewLine + "City: " + city +
                Environment.NewLine + "Province / State: " + province +
                Environment.NewLine + "Zip Code: " + code +
                Environment.NewLine + "Date: " + date +
                Environment.NewLine + "BirthDate: " + birthdate +
                Environment.NewLine + "Age: " + age +
                Environment.NewLine + "Allerg Description: " + allergyDescription +
                Environment.NewLine + "BMI: " + bmi +
                Environment.NewLine + "Desired BMI: " + bmiWant);
        }

        private void bmiNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void calcBMI_Click(object sender, EventArgs e)
        {
            try
            {
                double bmi;
                bmi = double.Parse(weighttbx.Text) / (double.Parse(weighttbx.Text) * double.Parse(weighttbx.Text));
                bmiNumber.Text = bmi.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
