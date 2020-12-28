using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Permissions;
using System.Windows.Forms;

namespace СourseWorkAfanasieva
{
    public partial class Form1 : Form
    {
        List<Disk> listOfDisks;
        FileSystemWatcher watcher;
        int index = 0;
        public Form1()
        {
           
            listOfDisks = new List<Disk>();
            watcher = new FileSystemWatcher();
            InitializeComponent();
            initialaziDisks();
            initialazeNumericUp();
            radioPercent.Checked = true;

        }

        private void initialazeNumericUp()
        {
            persent.Minimum = 1;
            persent.Maximum = 100;
            gigabyte.Maximum = listOfDisks[index].totalSize;
        }

        private  void initialaziDisks()
        {
            clearDisksList();
            getListOfDisksFromSystemtoList();
           
        }

        private void getListOfDisksFromSystemtoList()
        {
            DriveInfo[] disks = DriveInfo.GetDrives();
            foreach (DriveInfo item in disks)
            {
                if (item.DriveType == DriveType.Fixed)
                {
                    disk.Items.Add(item.Name);
                    listOfDisks.Add(new Disk(item.Name, item.TotalFreeSpace, item.TotalSize));
                }
            }
            disk.SelectedIndex = 0;
        }

        private void getListOfDisksFromSystem()
        {
            DriveInfo[] disks = DriveInfo.GetDrives();
            foreach (DriveInfo item in disks)
            {
                if (item.DriveType == DriveType.Fixed)
                {
                    if (item.Name.Equals(listOfDisks[index].name))
                    {
                        listOfDisks[index].totalFreeSpace = listOfDisks[index].totalSpaceCount(item.TotalFreeSpace);
                    }
                }
            }
        }

        private void clearDisksList()
        {
            disk.Items.Clear();
            listOfDisks.Clear();
           

        }

        private void disk_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Stop_Click(null, null);
            index = disk.SelectedIndex;
            initialazeNumericUp();
        }


        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        private void startButton_Click(object sender, EventArgs e)
        {
            watcher = new FileSystemWatcher();

            watcher.Path = listOfDisks[index].name;

            watcher.NotifyFilter = NotifyFilters.Size;
            watcher.Filter = "*.*";
            watcher.IncludeSubdirectories = true;

            watcher.Changed += OnChanged;
            watcher.Created += OnChanged;
            watcher.Deleted += OnChanged;
            //watcher.Renamed += OnChanged;

            watcher.EnableRaisingEvents = true;
        }

        private  void OnChanged(object source, FileSystemEventArgs e)
        {
            try
            {
                watcher.EnableRaisingEvents = false;
                if (radioPercent.Checked)
                {
                   countPersent();
                } 
                else
                {
                    alertCheck((int)gigabyte.Value);
                }
                
            }
            finally
            {
                watcher.EnableRaisingEvents = true;
            }
        }

        private void countPersent() 
        {
            int counterOfpersentAlert = listOfDisks[index].totalSize * (int)(persent.Value) / 100;
            alertCheck(counterOfpersentAlert);
        }

        private void alertCheck(int counterOfAlert)
        {
           if(counterOfAlert > listOfDisks[index].totalFreeSpace)
            {
                MessageBox.Show("Свободное пространство достигло порогового уровня!!!");
                getListOfDisksFromSystem();
            }
        }

        private void radioButton_checkedChanged(object sender, EventArgs e)
        {
            Stop_Click(null, null);
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            watcher.EnableRaisingEvents = false;
        }

        private void gigabyte_ValueChanged(object sender, EventArgs e)
        {
            Stop_Click(null, null);
        }

        private void persent_ValueChanged(object sender, EventArgs e)
        {
            Stop_Click(null, null);
        }
    }
 
}
