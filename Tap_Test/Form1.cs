using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tap_Test
{
    public partial class MainPage : Form
    {
        DriverList addedDriversList = new DriverList();
        List<FareInfo> addedFaresList = new List<FareInfo>();
        public MainPage()
        {
            InitializeComponent();
            typesList.Items.Add("Taxi");
            driversList.Items.Add("Best");
            fareList.SelectionMode = SelectionMode.One;

        }

        //Buttons

        private void addDriver_Click(object sender, EventArgs e)
        {
            ToggleAddDriver(true);
        }

        private void loadCsv_Click(object sender, EventArgs e)
        {
            if (openCSVDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var fares = FileManager.GetFares(openCSVDialog.FileName);
                    foreach (var eachFare in fares)
                    {
                        fareList.Items.Add(eachFare.ToListString());
                        addedFaresList.Add(eachFare);
                    }
                    calculateFareButton.Enabled = fareList.Items.Count > 0 && driversList.Items.Count > 0;

                    
                }
                catch (FieldAccessException ex)
                {
                    MessageBox.Show($"Could not open file.\n\nError message: {ex.Message}\n\n" +
                        $"Details:\n\n{ex.StackTrace}");
                }
            }
        }

        private void calculateFare_Click(object sender, EventArgs e)
        {
            var calculatedFare = addedFaresList[fareList.CheckedIndices[0]];
            fareInfo.Text = calculatedFare.ToListString();
            float value;
            string driver;
            if (driversList.CheckedIndices[0] != 0){
                value = addedDriversList.GetDriverByIndex(driversList.CheckedIndices[0]-1).GetCost(calculatedFare);
                driver = addedDriversList.GetDriverByIndex(driversList.CheckedIndices[0]-1).FullName();
            }
            else
                (value, driver) = addedDriversList.FindLowestFare(calculatedFare);
            fareResult.Text = value.ToString();
            driverChosen.Text = driver;
        }

        private void addPush_Click(object sender, EventArgs e)
        {
            int price;
            int distance;
            if (nameBox.TextLength > 0 &&
                surnameBox.TextLength > 0 &&
                emailBox.TextLength > 0 &&
                typesList.CheckedItems.Count > 0 &&
                int.TryParse(priceBox.Text, out price) &&
                int.TryParse(distanceBox.Text, out distance)
                )
            {
                var newDriver = new VehicleDriver(nameBox.Text, surnameBox.Text, emailBox.Text, GetVehicleType(typesList.CheckedItems[0].ToString()), price, distance);
                addedDriversList.AddTaxiDriver(newDriver);
                driversList.Items.Add(newDriver.ToListString());
                ClearDriverData();
                ToggleAddDriver(false);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ToggleAddDriver(false);
            ClearDriverData();
        }

        //Utility Functions
        private void ToggleAddDriver(bool activate)
        {
            typeLabel.Enabled = activate;
            typesList.Enabled = activate;
            nameLabel.Enabled = activate;
            nameBox.Enabled = activate;
            surnameLabel.Enabled = activate;
            surnameBox.Enabled = activate;
            emailLabel.Enabled = activate;
            emailBox.Enabled = activate;
            priceLabel.Enabled = activate;
            priceBox.Enabled = activate;
            distanceLabel.Enabled = activate;
            distanceBox.Enabled = activate;
            addDriverButton.Enabled = !activate;
            loadCsvButton.Enabled = !activate;
            calculateFareButton.Enabled = !activate && (fareList.Items.Count > 0 && driversList.Items.Count > 0);
            addPushButton.Enabled = activate;
            cancelButton.Enabled = activate;
        }

        private void ClearDriverData()
        {
            typesList.ClearSelected();
            nameBox.Clear();
            surnameBox.Text = "";
            emailBox.Text = "";
            priceBox.Text = "";
            distanceBox.Text = "";
        }

        VehicleType GetVehicleType(string typeString)
        {
            switch (typeString)
            {
                case "Taxi":
                    return VehicleType.TAXI;
                default:
                    throw new ArgumentException("Unavailable vehicle type");
            }
        }
    }
}
