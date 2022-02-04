using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CopyPractice
{
    public partial class FileRename : Form
    {
        public FileRename()
        {
            InitializeComponent();
        }

        /// <summary>
        /// FileRename_Shownイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileRename_Shown(object sender, EventArgs e)
        {
            //初期処理
            txtInputDir.Clear();
            fileClear();
        }

        /// <summary>
        /// 参照ボタンクリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRef_Click(object sender, EventArgs e)
        {
            ///FolderBrowserDialogクラスのインスタンスを作成
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = @"フォルダを指定してください。";
                fbd.RootFolder = Environment.SpecialFolder.Desktop;
                string initSelectPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (string.IsNullOrWhiteSpace(txtInputDir.Text) == false)
                {
                    initSelectPath = txtInputDir.Text;
                }
                fbd.SelectedPath = initSelectPath;
                fbd.ShowNewFolderButton = true;
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    return;
                }
                string selectPath = fbd.SelectedPath;
                txtInputDir.Text = selectPath;
            }
            fileClear();
            this.btnLoad.Focus();
        }

        /// <summary>
        /// 読み込みボタンクリック処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            fileClear();
            string selectPath = txtInputDir.Text;
            //入力チェック
            if (string.IsNullOrWhiteSpace(txtInputDir.Text) == true)
            {
                MessageBox.Show("フォルダを選択してください", "入力エラー", MessageBoxButtons.OK);
                this.txtInputDir.Focus();
                return;
            }
            if (Directory.Exists(selectPath) == false)
            {
                MessageBox.Show("存在するフォルダを選択してください", "入力エラー", MessageBoxButtons.OK);
                this.txtInputDir.Focus();
                return;
            }
            int filesCount = showFiles();
            fileCountLabel(filesCount);
            changeEnableBtnRename();
        }

        /// <summary>
        /// lstLoadFiles内のItem選択時
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstLoadFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selIdx = lstLoadFiles.SelectedIndex;
            string item = lstLoadFiles.Items[selIdx].ToString();
            string selectDir = txtInputDir.Text;
        }

        /// <summary>
        /// btnRenameを押したときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRename_Click(object sender, EventArgs e)
        {
            int itemsCount = lstLoadFiles.Items.Count;
            int errCount = 0;
            for (int i = 0; i < itemsCount; i++)
            {
                string selectDir = txtInputDir.Text;
                string selectedItem = lstLoadFiles.Items[i].ToString();
                string fileName = Path.GetFileNameWithoutExtension(selectedItem);
                string extension = Path.GetExtension(selectedItem);
                //元のファイルのfullPath
                string fullPath = selectDir + @"\" + fileName + extension;
                //ファイル名を新規作成日に置換
                DateTime fileCreate = File.GetCreationTime(fullPath);
                string afterSelectedItem = selectedItem.Replace(fileName, fileCreate.ToString($"yyyyMMdd_{i + 1}"));
                //変更後のfullPath
                string afterFullPath = selectDir + @"\" + afterSelectedItem;
                //リネーム
                try
                {
                    File.Move(fullPath, afterFullPath);
                }
                catch (IOException ex)
                {
                    errCount += 1;
                    MessageBox.Show($"ファイル名{fileName}：{ex.Message}", "エラー");
                }
            }
            showFiles();
            MessageBox.Show($"{itemsCount}件中{itemsCount - errCount}件成功しました", "ファイル名変更");
        }


        /// <summary>
        /// 初期設定
        /// </summary>
        private void fileClear()
        {
            lstLoadFiles.Items.Clear();
            changeEnableBtnRename();
            fileCountLabel(0);
        }

        /// <summary>
        /// btnRenameが押せるかどうか
        /// </summary>
        private void changeEnableBtnRename()
        {
            bool hasItem = (lstLoadFiles.Items.Count > 0);
            btnRename.Enabled = hasItem;
        }

        /// <summary>
        /// ファイル件数の表示
        /// </summary>
        /// <param name="fileCount">ファイルの件数</param>
        private void fileCountLabel(int fileCount)
        {
            lblFileCount.Text = $"ファイル件数:{fileCount}件";
        }

        /// <summary>
        /// リストボックスにファイル名を表示
        /// </summary>
        /// <returns>表示したファイル件数を返す</returns>
        private int showFiles()
        {
            lstLoadFiles.Items.Clear();
            string selectDir = txtInputDir.Text;
            string filter = @"*";
            string[] files = System.IO.Directory.GetFiles(selectDir, filter, System.IO.SearchOption.TopDirectoryOnly);

            //一括で表示する方法
            //ListBox1に結果を表示する
            //listBox1.Items.AddRange(files);

            //1つずつ表示する方法
            for (int i = 0; i < files.Length; i++)
            {
                string pathBefore = files[i];
                string pathAfter = pathBefore.Replace(selectDir + @"\", "");
                this.lstLoadFiles.Items.Add(pathAfter);
            }
            return files.Length;
        }
    }
}
