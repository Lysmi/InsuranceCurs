using System;
using System.IO;
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
    public partial class Form1 : Form
    {
        List<string> manFirstNames = new List<string>();
        List<string> womanFirstNames = new List<string>();
        List<string> manSurnames = new List<string>();
        List<string> womanSurnames = new List<string>();
        List<string> manPatronimics = new List<string>();
        List<string> womanPatronimics = new List<string>();
        List<string> cities = new List<string>();
        List<string> streets = new List<string>();
        List<string> socials = new List<string>();
        List<string> properties = new List<string>();
        List<string> variants = new List<string>();
        List<string> companyNames = new List<string>();
        List<byte[]> imageLicense = new List<byte[]>();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Generate();
            UpdateDataSource();
        }

        private void UpdateDataSource()
        {
            using (Database.InsuranceContext context = new Database.InsuranceContext())
            {
                clientDataGridView.DataSource = context.Clients.ToList();

                contractsDataGridView.DataSource = context.Contracts.ToList();

                workersDataGridView.DataSource = context.Workers.ToList();

                citiesDataGridView.DataSource = context.Cities.ToList();

                officeDataGridView.DataSource = context.Offices.ToList();

                branchDataGridView.DataSource = context.Branches.ToList();

                licenseDataGridView.DataSource = context.Licenses.ToList();

                insVariantDataGridView.DataSource = context.InsuranseVariants.ToList();

                typePropDataGridView.DataSource = context.TypeProperties.ToList();

                SocialDataGridView.DataSource = context.Socials.ToList();

            }
        }

        public byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }

        private void readFiles()
        {
            StreamReader streamReader = new StreamReader("res/name/man/firstNames.txt");
            string name;
            while ((name = streamReader.ReadLine()) != null)
            {
                manFirstNames.Add(name);
            }
            streamReader = new StreamReader("res/name/woman/firstNames.txt");
            while ((name = streamReader.ReadLine()) != null)
            {
                womanFirstNames.Add(name);
            }

            streamReader = new StreamReader("res/name/man/surname.txt");
            while ((name = streamReader.ReadLine()) != null)
            {
                manSurnames.Add(name);
            }
            streamReader = new StreamReader("res/name/woman/surname.txt");
            while ((name = streamReader.ReadLine()) != null)
            {
                womanSurnames.Add(name);
            }
        
            streamReader = new StreamReader("res/name/man/patronimic.txt");
            while ((name = streamReader.ReadLine()) != null)
            {
                manPatronimics.Add(name);
            }
            streamReader = new StreamReader("res/name/woman/patronimic.txt");
            while ((name = streamReader.ReadLine()) != null)
            {
                womanPatronimics.Add(name);
            }

            streamReader = new StreamReader("res/adress/cities.txt");
            string city;
            while ((city = streamReader.ReadLine()) != null)
            {
                cities.Add(city);
            }

            streamReader = new StreamReader("res/adress/streets.txt");
            string street;
            while ((street = streamReader.ReadLine()) != null)
            {
                streets.Add(street);
            }

            streamReader = new StreamReader("res/social.txt");
            string social;
            while ((social = streamReader.ReadLine()) != null)
            {
                socials.Add(social);
            }

            streamReader = new StreamReader("res/property.txt");
            string property;
            while ((property = streamReader.ReadLine()) != null)
            {
                properties.Add(property);
            }
            
            for (int i = 0; i < 4; i++)
            {
                Bitmap image = new Bitmap("res/photo/" + (i+1).ToString() + ".jpg");
                imageLicense.Add(imageToByteArray(image));
            }

            streamReader = new StreamReader("res/insVariant.txt");
            string variant;
            while ((variant = streamReader.ReadLine()) != null)
            {
                variants.Add(variant);
            }

            streamReader = new StreamReader("res/companyName.txt");
            string companyName;
            while ((companyName = streamReader.ReadLine()) != null)
            {
                companyNames.Add(companyName);
            }

        }

        private string createArdress(Random random)
        {
            return "Россия, г." + cities[random.Next(cities.Count)] + ", ул. " + streets[random.Next(streets.Count)] + ", д. " + random.Next(1, 100);
        }

        private string createArdress(Random random, int idCity)
        {
            using (Database.InsuranceContext context = new Database.InsuranceContext())
                return "Россия, г." + context.Cities.Find(idCity).Name + ", ул. " + streets[random.Next(streets.Count)] + ", д. " + random.Next(1, 100);
        }

        private string createPhone(Random random)
        {
            string phone = "+7";
            for (int j = 0; j < 10; j++)
            {
                phone += random.Next(0, 10);
            }
            return phone;
        }

        private void Generate()
        {
            using (Database.InsuranceContext context = new Database.InsuranceContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();
            }
            readFiles();
            Random random = new Random();
            using (Database.InsuranceContext context = new Database.InsuranceContext())
            {            
                foreach (string curSocial in socials)
                {
                    Database.models.Social newSocial = new Database.models.Social();
                    newSocial.Position= curSocial;
                    context.Socials.Add(newSocial);   
                }
                context.SaveChanges();

                foreach (string curProperty in properties)
                {
                    Database.models.TypeProperty newProperty = new Database.models.TypeProperty();
                    newProperty.Type = curProperty;
                    context.TypeProperties.Add(newProperty);
                }
                context.SaveChanges();

                foreach (string curCity in cities)
                {
                    Database.models.City newCity= new Database.models.City();
                    newCity.Name = curCity;
                    context.Cities.Add(newCity);
                }
                context.SaveChanges();

                for (int i = 0; i < 10000; i++)
                {
                    Database.models.Client newClient = new Database.models.Client();
                    if (random.NextDouble() < 0.5)
                    {
                        newClient.FirstName = manFirstNames[random.Next(manFirstNames.Count)];
                        newClient.Surname = manSurnames[random.Next(manSurnames.Count)];
                        newClient.Patronimic = manPatronimics[random.Next(manPatronimics.Count)];
                    }
                    else
                    {
                        newClient.FirstName = womanFirstNames[random.Next(womanFirstNames.Count)];
                        newClient.Surname = womanSurnames[random.Next(womanSurnames.Count)];
                        newClient.Patronimic = womanPatronimics[random.Next(womanPatronimics.Count)];
                    }
                    newClient.CityID = context.Cities.Find(random.Next(cities.Count) + 1).ID;

                    newClient.House = createArdress(random, newClient.CityID);
                    newClient.Phone = createPhone(random);
                    newClient.SocialID = context.Socials.Find(random.Next(socials.Count)+1).ID;
                    newClient.Birthday = new DateTime(random.Next(1930,2003), random.Next(12)+1, random.Next(28)+1);
                    context.Clients.Add(newClient);
                }
                context.SaveChanges();

                foreach (byte[] curImage in imageLicense)
                {
                    Database.models.License newLicense = new Database.models.License();
                    newLicense.Num = random.Next(500000);
                    newLicense.DataLicense = new DateTime(random.Next(2022, 2030), random.Next(12) + 1, random.Next(28) + 1);
                    newLicense.PhotoLicense = curImage;
                    context.Licenses.Add(newLicense);
                }

                context.SaveChanges();
                foreach (string curVariant in variants)
                {
                    Database.models.InsuranseVariant newVariant = new Database.models.InsuranseVariant();
                    newVariant.Variant = curVariant;
                    context.InsuranseVariants.Add(newVariant);
                }
                context.SaveChanges();

                for (int i = 0; i < imageLicense.Count; i++)
                {
                    Database.models.Office newOffice = new Database.models.Office();
                    newOffice.Name = companyNames[i];
                    newOffice.Phone = createPhone(random);
                    newOffice.CityID = context.Cities.Find(random.Next(cities.Count) + 1).ID;
                    newOffice.Adress = createArdress(random, newOffice.CityID);
                    newOffice.LicenseID = context.Licenses.Find(i + 1).ID;
                    newOffice.TypePropertyID = context.TypeProperties.Find(random.Next(context.TypeProperties.Count()) + 1).ID;
                    newOffice.Year = random.Next(1930, 2000);
                    context.Offices.Add(newOffice);
                }
                context.SaveChanges();

                for (int i = 0; i < 20; i++)
                {
                    Database.models.Branch newBranch = new Database.models.Branch();
                    newBranch.Phone = createPhone(random);
                    newBranch.CityID = context.Cities.Find(random.Next(cities.Count) + 1).ID;
                    newBranch.Adress = createArdress(random, newBranch.CityID);
                    newBranch.OfficeID = context.Offices.Find(random.Next(context.Offices.Count()) + 1).ID;
                    newBranch.AmountWorkers = 0;
                    newBranch.Year = random.Next(2022, 2122);
                    context.Branches.Add(newBranch);
                }
                context.SaveChanges();

                for (int i = 0; i < 1000; i++)
                {
                    Database.models.Worker newWorker = new Database.models.Worker();
                    if (random.NextDouble() < 0.5)
                    {
                        newWorker.FirstName = manFirstNames[random.Next(manFirstNames.Count)];
                        newWorker.Surname = manSurnames[random.Next(manSurnames.Count)];
                        newWorker.Patronimic = manPatronimics[random.Next(manPatronimics.Count)];
                    }
                    else
                    {
                        newWorker.FirstName = womanFirstNames[random.Next(womanFirstNames.Count)];
                        newWorker.Surname = womanSurnames[random.Next(womanSurnames.Count)];
                        newWorker.Patronimic = womanPatronimics[random.Next(womanPatronimics.Count)];
                    }
                    newWorker.BranchID = random.Next(20) + 1;
                    context.Branches.Find(newWorker.BranchID).AmountWorkers++;
                    context.Workers.Add(newWorker);
                }

                
                context.SaveChanges();

                for (int i = 0; i < 10000+random.Next(5000); i++)
                {
                    Database.models.Contract newContract = new Database.models.Contract();                  
                    newContract.Sum = random.Next(100000) / 100f;
                    newContract.Text = "Данный договор страхования...";
                    newContract.ClientID = context.Clients.Find(random.Next(context.Clients.Count()) + 1).ID;
                    newContract.InsuranseID = context.InsuranseVariants.Find(random.Next(context.InsuranseVariants.Count()) + 1).ID;
                    newContract.WorkerID = context.Workers.Find(random.Next(context.Workers.Count()) + 1).ID;
                    newContract.Phone = context.Clients.Find(newContract.ClientID).Phone;
                    newContract.Date = new DateTime(random.Next(2018, 2021), random.Next(12) + 1, random.Next(28) + 1);
                    context.Contracts.Add(newContract);
                }
                context.SaveChanges();
            }          
        }

        private void deleteClient_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in clientDataGridView.SelectedRows)
            {
                int id = (int)row.Cells[0].Value;
                using (Database.InsuranceContext context = new Database.InsuranceContext())
                {
                    context.Clients.Remove(context.Clients.Find(id));
                    context.SaveChanges();
                }
            }
            UpdateDataSource();
        }

        private void addElem_Click(object sender, EventArgs e)
        {
   
            ClientAdd clientAdd = new ClientAdd();
            clientAdd.ShowDialog();
        }
    }
}
