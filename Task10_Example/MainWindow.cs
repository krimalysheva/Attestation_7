﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
using ProgramLogic;
using System.Threading;
using System.Globalization;

/*
 Звукозапись. 
Определить иерархию музыкальных композиций. 
Записать на диск сборку. 
Подсчитать продолжительность. 
Провести перестановку композиций диска на основе принадлежности к стилю. 
Найти композицию, соответствующую заданному диапазону длины треков.
     */

namespace L1_Form
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            //using (System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.IDisposable.InvariantCulture) ;
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            DataGridViewUtils.InitGridForArr(InputCompositionsDGV, 40, false, true, true, true, false);
        }

        private void SortCompositionsbttn_Click(object sender, EventArgs e)
        {
            try
            {
                List<Composition> compositions = CompositionsDGVConvert.DGVToCompositionsList(InputCompositionsDGV);
                CompositionsDGVConvert.CompositionsListToDGV(InputCompositionsDGV, Disk.Sort(compositions));
            }
            catch (Exception ex)
            {
                MessagesUtils.ShowError("Произошла ошибка!");
            }
        }

        private void MainMenuFileOpen_Click(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = OpenFileDialog.FileName;

                    List<Composition> compositionsList = CompositionsFilesUtils.ReadCompositionFromFile(path);
                    CompositionsDGVConvert.CompositionsListToDGV(InputCompositionsDGV, compositionsList);

                    MessagesUtils.ShowMessage("Данные загружены из файла");
                }
                catch (Exception ex)
                {
                    MessagesUtils.ShowError("Ошибка чтения из файла");
                }
            }
        }

        private void MainMenuFileSave_Click(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string path = SaveFileDialog.FileName;

                    List<Composition> compositionsList = CompositionsDGVConvert.DGVToCompositionsList(InputCompositionsDGV);
                    CompositionsFilesUtils.SaveCompositionsToFile(path, compositionsList);

                    MessagesUtils.ShowMessage("Данные сохранены в файл");
                }
                catch (Exception ex)
                {
                    MessagesUtils.ShowError("Ошибка сохранения в файл");
                }
            }
        }

        private void countSoundbttn_Click(object sender, EventArgs e)
        {
            try
            {
                List<Composition> compositions = CompositionsDGVConvert.DGVToCompositionsList(InputCompositionsDGV);
                countSoundlbl.Text = Convert.ToString(Disk.CountSound(compositions));
            }
            catch (Exception ex)
            {
                MessagesUtils.ShowError("Произошла ошибка!");
            }
        }

        private void Searchbttn_Click(object sender, EventArgs e)
        {
            try
            {
                List<Composition> compositions = CompositionsDGVConvert.DGVToCompositionsList(InputCompositionsDGV);
                List<Composition> foundedCompositions = Disk.Search(compositions, (double)Fromnum.Value, (double)Tonum.Value);

                string result = "";

                foreach (Composition composition in foundedCompositions)
                {
                    result += composition.Name + Environment.NewLine;
                }

                searchlbl.Text = result;
            }
            catch (Exception ex)
            {
                MessagesUtils.ShowError("Произошла ошибка!");
            }

        }
    }
}