using System;
using System.Windows;

namespace JobList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class Job_List : Window
    {
        string[] jobs = { "Living Room", "Dining Room", "Family Room", "Dishes", "Kitchen" };

        public Job_List()
        {
            InitializeComponent();
        }
        private void Generate(object sender, RoutedEventArgs e)
        {
            //prepare string today in MM/dd format
            DateTime today = DateTime.Today;
            string day = string.Format("{0:MM-dd}", today);
            Console.WriteLine(day);

            //prepare string month in full month name format, create directory in Job Lists if it isn't already there 
            string month = DateTime.Now.ToString("MMMM");
            string filepath = "C:\\Users\\Steve\\Documents\\Job Lists\\" + month;
            System.IO.Directory.CreateDirectory(filepath);

            //change filepath to new directory, but now a new txt file named after today
            filepath = filepath + "\\" + day + ".txt";

            //Check if list already exists, if so delete it
            if (System.IO.File.Exists(filepath))
            {
                System.IO.File.Delete(filepath);
            }

            //array of strings for jobs
            string[] Jobs = { "Dishes", "Kitchen", "Family", "Dining", "Living" };

            //Create file
            using (System.IO.StreamWriter sw = System.IO.File.CreateText(filepath))
            {
                string didJob;
                string Job;
                Random r = new Random();
                int index;

                sw.WriteLine("JOB LIST - " + day);
                sw.WriteLine("\nChild:\t\tJob:\t\tDid Job Yesterday?\n");
                sw.WriteLine("-------------------------------------------------");

                //MK
                index = r.Next(0, 4);
                Job = Jobs[index];
                if (MK.IsChecked == true) { didJob = "y"; }
                else { didJob = "NO"; }
                sw.WriteLine("MK\t\t" + Job + "\t\t" + didJob);
                sw.WriteLine("\n");
                Jobs[index] = "DONE";

                //Reece
                index = r.Next(0, 4);
                while (Jobs[index] == "DONE")
                {
                    //if Job is already done, find a new random job
                    index = r.Next(0, 4);
                }
                Job = Jobs[index];
                if (Reece.IsChecked == true) { didJob = "y"; }
                else { didJob = "NO"; }
                sw.WriteLine("Reece\t\t" + Job + "\t\t" + didJob);
                sw.WriteLine("\n");
                Jobs[index] = "DONE";

                //Daniel
                index = r.Next(0, 4);
                while (Jobs[index] == "DONE")
                {
                    //if Job is already done, find a new random job
                    index = r.Next(0, 4);
                }
                Job = Jobs[index];
                if (Daniel.IsChecked == true) { didJob = "y"; }
                else { didJob = "NO"; }
                sw.WriteLine("Daniel\t\t" + Job + "\t\t" + didJob);
                sw.WriteLine("\n");
                Jobs[index] = "DONE";

                //Christopher
                index = r.Next(0, 4);
                while (Jobs[index] == "DONE")
                {
                    //if Job is already done, find a new random job
                    index = r.Next(0, 4);
                }
                Job = Jobs[index];
                if (Christopher.IsChecked == true) { didJob = "y"; }
                else { didJob = "NO"; }
                sw.WriteLine("Christopher\t" + Job + "\t\t" + didJob);
                Jobs[index] = "DONE";
            }

            //Job list creating, closing
            this.Close();
            
        }
    }
}
