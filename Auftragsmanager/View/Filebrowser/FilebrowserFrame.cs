﻿using System;
using System.Windows.Forms;
using System.IO;
using Repository.Persistence;

namespace View
{
    public partial class FilebrowserFrame : Form
    {
        private Unit _unit;
        private static FilebrowserFrame instance;
        private string orderID;
        private FilebrowserFrame(Unit unit,string _orderID)
        {
            _unit = unit;
            orderID = _orderID;
            InitializeComponent();
            DisplayFiles(FileSearchFilterInput.Text);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.FormClosing += closeEvent;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private void closeEvent(object sender, FormClosingEventArgs e)
        {
            instance = null;
        }

        public static FilebrowserFrame Instance(Unit unit, string _orderID)
        {
            if (instance == null)
            {
                instance = new FilebrowserFrame(unit, _orderID);
            }
            instance.BringToFront();
            return instance;
        }
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            if (FileDisplayListBox.SelectedItem != null)
            {
                _unit.Files.OpenFile(orderID, FileDisplayListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Es muss erst eine Datei ausgewählt werden.", @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FileUploadButton_Click(object sender, EventArgs e)
        {
            if (FileDialog.ShowDialog(this) == DialogResult.OK)
            {
                _unit.Files.UploadFile(orderID, Path.GetFileName(FileDialog.FileName), FileDialog.FileName);
            }
            DisplayFiles(FileSearchFilterInput.Text);
        }
        private void FileDownloadButton_Click(object sender, EventArgs e)
        {
            if (FileDisplayListBox.SelectedItem != null)
            {
                _unit.Files.DownloadFile(orderID, FileDisplayListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Es muss erst eine Datei ausgewählt werden.", @"Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void FileSearchFilterInput_KeyUp(object sender, KeyEventArgs e)
        {
            DisplayFiles(FileSearchFilterInput.Text);
        }
        private void DisplayFiles(string filter)
        {
            FileDisplayListBox.Items.Clear();
            string[] files = _unit.Files.DisplayFiles(orderID);
            foreach (string file in files)
            {
                if (file.Contains(filter))
                {
                    FileDisplayListBox.Items.Add(Path.GetFileName(file));
                }
            }
        }
    }
}
