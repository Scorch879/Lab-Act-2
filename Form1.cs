namespace Lab_Act_2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            allergyDesc.Enabled = false;
            allergyYes.CheckedChanged += RadioButton_CheckedChanged;
            allergyNo.CheckedChanged += RadioButton_CheckedChanged;
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime date = calendar.SelectionStart;
            datetbx.Text = date.ToShortDateString();
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
            string sleepyTime, wakeyTime, totalTimeOfSleep, rest = "", sleepQuality, waterDrink, drinkCoffee, drinkAlcohol;
            string movement, movePerWeek, typeOfExercise, rateEnergy = "";
            string work, enjoy, stressFactors, dailyEnergyLevel = "";
            string meal1, mealLast, dailyMeal, snacko, frequencyEatingOut = "", placeEatOut;
            string weightCurrent, weightGoal, heightCurrent;

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

            sleepyTime = sleepTime.Text;
            wakeyTime = wakeTime.Text;
            totalTimeOfSleep = hrsOfSleep.Text;
            sleepQuality = qualitySleep.Text;

            waterDrink = drinkWater.Text;
            drinkCoffee = coffeeDrink.Text;
            drinkAlcohol = alcoholDrink.Text;

            movement = movementIssue.Text;
            movePerWeek = exerciseTime.Text;
            typeOfExercise = exerciseType.Text;

            work = worktbx.Text;
            enjoy = enjoytbx.Text;
            stressFactors = stressdesctbx.Text;

            meal1 = firstmealtbx.Text;
            mealLast = lastmealtbx.Text;
            dailyMeal = mealspDaytbx.Text;
            snacko = snackOntbx.Text;
            placeEatOut = eatOuttbx.Text;

            weightCurrent = currentWeight.Text;
            weightGoal = goalWeight.Text;
            heightCurrent = currentHeight.Text;

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
            else if (pregnantNo.Checked)
            {
                pregnantStat = pregnantNo.Text;
            }
            else
            {
                pregnantStat = rdnNA.Text;
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

            //rest
            if (restYes.Checked)
            {
                rest = restYes.Text;
            }
            if (restNo.Checked)
            {
                rest = restNo.Text;
            }
            if (otherRest.Checked)
            {
                rest = otherRest.Text;
            }

            //Rate of Energy
            if (rate1.Checked)
            {
                rateEnergy = rate1.Text;
            }
            if (rate2.Checked)
            {
                rateEnergy = rate2.Text;
            }
            if (rate3.Checked)
            {
                rateEnergy = rate3.Text;
            }
            if (rate4.Checked)
            {
                rateEnergy = rate4.Text;
            }
            if (rate5.Checked)
            {
                rateEnergy = rate5.Text;
            }
            if (rate6.Checked)
            {
                rateEnergy = rate6.Text;
            }
            if (rate7.Checked)
            {
                rateEnergy = rate7.Text;
            }
            if (rate8.Checked)
            {
                rateEnergy = rate8.Text;
            }
            if (rate9.Checked)
            {
                rateEnergy = rate9.Text;
            }
            if (rate10.Checked)
            {
                rateEnergy = rate10.Text;
            }

            //energy level
            if (stresslvl1.Checked)
            {
                dailyEnergyLevel = stresslvl1.Text;
            }
            if (stresslvl2.Checked)
            {
                dailyEnergyLevel = stresslvl2.Text;
            }
            if (stresslvl3.Checked)
            {
                dailyEnergyLevel = stresslvl3.Text;
            }
            if (stresslvl4.Checked)
            {
                dailyEnergyLevel = stresslvl4.Text;
            }
            if (stresslvl5.Checked)
            {
                dailyEnergyLevel= stresslvl5.Text;
            }

            //often eat out
            if (always.Checked)
            {
                frequencyEatingOut = always.Text;
            }
            if (sometimes.Checked)
            {
                frequencyEatingOut = sometimes.Text;
            }
            if (never.Checked)
            {
                frequencyEatingOut = never.Text;
            }
            if (usually.Checked)
            {
                frequencyEatingOut = usually.Text;
            }
            if (rarely.Checked)
            {
                frequencyEatingOut= rarely.Text;
            }
            if (other.Checked)
            {
                frequencyEatingOut = other.Text;
            }
            
            
            MessageBox.Show("Successfully Added Informations" + Environment.NewLine +
                Environment.NewLine + "Name: " + name +
                Environment.NewLine + "Address: " + address +
                Environment.NewLine + "City: " + city +
                Environment.NewLine + "Province / State: " + province +
                Environment.NewLine + "Zip Code: " + code +
                Environment.NewLine + "Date: " + date +
                Environment.NewLine + "BirthDate: " + birthdate +
                Environment.NewLine + "Age: " + age +
                Environment.NewLine + "Allerg Description: " + allergyDescription +
                Environment.NewLine + "BMI: " + bmi +
                Environment.NewLine + "Desired BMI: " + bmiWant +
                Environment.NewLine + "Sleep Time: " + sleepyTime +
                Environment.NewLine + "Wake Time: " + wakeyTime +
                Environment.NewLine + "Total Time of Sleep: " + totalTimeOfSleep +
                Environment.NewLine + "Quality of Sleep: " + sleepQuality +
                Environment.NewLine + "Frequency of Drinking Water: " + waterDrink +
                Environment.NewLine + "Frequency of Drinking Coffee: " + drinkCoffee +
                Environment.NewLine + "Frequency of Drinking Coffee: " + drinkAlcohol +
                Environment.NewLine + "Movement Issues: " + movement +
                Environment.NewLine + "Exercise Time: " + movePerWeek +
                Environment.NewLine + "Daily Energy Level: " + dailyEnergyLevel +
                Environment.NewLine + "Type of Exercise: " + typeOfExercise + 
                Environment.NewLine + "Work: " + work +
                Environment.NewLine + "Do you enjoy what you do? " + enjoy +
                Environment.NewLine + "Stress Factors: " + stressFactors +
                Environment.NewLine + "Rate of Daily Energy Level: " + dailyEnergyLevel +
                Environment.NewLine + "When is first meal eaten: " + meal1 +
                Environment.NewLine + "When is the last meal eaten: " + mealLast +
                Environment.NewLine + "Snacks: " + snacko +
                Environment.NewLine + "Where do you typically eat out?: " + placeEatOut +
                Environment.NewLine + "How often do you eat out: " + frequencyEatingOut +
                Environment.NewLine + "Current Weight: " + weightCurrent + 
                Environment.NewLine + "Goal Weight: " + weightGoal +
                Environment.NewLine + "Height: " + heightCurrent,
                "Patient Information"
            );
        }

        private void calcBMI_Click(object sender, EventArgs e)
        {
            try
            {
                double bmi;

                if (weighttbx.Text == "" || heighttbx.Text == "")
                    throw new Exception("Please input both fields!");

                bmi = double.Parse(weighttbx.Text) / (double.Parse(heighttbx.Text) * double.Parse(heighttbx.Text));

                if (bmi == double.NaN)
                    throw new Exception("Invalid Operation executed!");
                bmiNumber.Text = bmi.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // Enable the text box only if the "Yes" radio button is checked
            if (allergyYes.Checked)
            {
                allergyDesc.Enabled = true; 
                allergyDesc.Focus();        
            }
            else
            {
                allergyDesc.Enabled = false; 
                allergyDesc.Clear();         
            }
        }
    }
}