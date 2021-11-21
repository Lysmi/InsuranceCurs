using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsuranceCurs
{
    public partial class ClientAdd : Form
    {
        public ClientAdd()
        {
            InitializeComponent();
            errorDate.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            using (Database.InsuranceContext context = new Database.InsuranceContext())
            {
                cityBox.Items.AddRange(context.Cities.ToArray());
                socialBox.Items.AddRange(context.Socials.ToArray());
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (cityBox == null)
            {
                errorDate.SetError(cityBox, "Выберете город");
            }
            else
            {
                errorDate.Clear();
                if (firstNameInput.Text == "")
                {
                    errorDate.SetError(cityBox, "Выберете имя");
                }
                else
                {
                    errorDate.Clear();
                    if (surnameInput.Text == "")
                    {
                        errorDate.SetError(cityBox, "Выберете имя");
                    }
                    else
                    {
                         
                    }
                    errorDate.Clear();
                    if (DateTime.Now - BirhdayPicker.Value >= new TimeSpan(new DateTime(18, 1, 1).Ticks))
                    {
                        errorDate.Clear();

                    }
                    else
                    {
                        errorDate.SetError(BirhdayPicker, "Клиент должен быть старше 18 лет");
                    }
                }
                
            }
            
        }
    }
}
