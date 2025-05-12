using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using static Castle.MicroKernel.ModelBuilder.Descriptors.InterceptorDescriptor;
using static Архивный_фонд.FormDescktop;

namespace Архивный_фонд
{
    public partial class FormDescktop : Form
    {
        MySqlCommand cmd;
        String line;
        string myConnString = "";
        string sql;

        public void fillTableSpec()
        {
            ClassListsData classListsData = new ClassListsData();
            List<ClassListsData.TableSpesial> specials = classListsData.getTableSpec();
            dataGridViewAll.Rows.Clear();
            dataGridViewAll.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewAll.RowCount = specials.Count;
            for (int i = 0; i < specials.Count; i++)
            {
                dataGridViewAll.Rows[i].Cells[0].Value = specials[i].id;
                dataGridViewAll.Rows[i].Cells[1].Value = specials[i].Kod;
                dataGridViewAll.Rows[i].Cells[2].Value = specials[i].Name;
                dataGridViewAll.Rows[i].Cells[3].Value = specials[i].Qualification;
            }
        }

        public void fillTableStud()
        {
            ClassListsData classListsData = new ClassListsData();
            List<ClassListsData.TableStud> tableStuds = classListsData.getTableStud();
            dataGridViewAll.Rows.Clear();
            dataGridViewAll.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewAll.RowCount = tableStuds.Count;
            for (int i = 0; i < tableStuds.Count; i++)
            {
                dataGridViewAll.Rows[i].Cells[0].Value = tableStuds[i].id;
                dataGridViewAll.Rows[i].Cells[1].Value = tableStuds[i].FIO;
                dataGridViewAll.Rows[i].Cells[2].Value = tableStuds[i].Group;
                dataGridViewAll.Rows[i].Cells[3].Value = tableStuds[i].God_nach_ob;
            }
        }

        public void fillTableStudSearch()
        {
            ClassListSort classListSort = new ClassListSort();
            List<ClassListSort.TableStudSearch> tableStuds = classListSort.getTableStudSearch(textBoxGroup.Text, textBoxFIOS.Text);
            dataGridViewAll.Rows.Clear();
            dataGridViewAll.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewAll.RowCount = tableStuds.Count;
            for (int i = 0; i < tableStuds.Count; i++)
            {
                dataGridViewAll.Rows[i].Cells[0].Value = tableStuds[i].id;
                dataGridViewAll.Rows[i].Cells[1].Value = tableStuds[i].FIO;
                dataGridViewAll.Rows[i].Cells[2].Value = tableStuds[i].Group;
                dataGridViewAll.Rows[i].Cells[3].Value = tableStuds[i].God_nach_ob;
            }
        }

        public void fillTableVidWork()
        {
            ClassListsData classListsData = new ClassListsData();
            List<ClassListsData.TableVidWork> tableTypeWorks = classListsData.getTableVidWork();
            dataGridViewAll.Rows.Clear();
            dataGridViewAll.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewAll.RowCount = tableTypeWorks.Count;
            for (int i = 0; i < tableTypeWorks.Count; i++)
            {
                dataGridViewAll.Rows[i].Cells[0].Value = tableTypeWorks[i].id;
                dataGridViewAll.Rows[i].Cells[1].Value = tableTypeWorks[i].Name_work;
            }
        }

        public void fillTablePersCase()
        {
            ClassListsData classListsData = new ClassListsData();
            List<ClassListsData.TablePersCase> tablePersCase = classListsData.getTablePersCase();
            dataGridViewAll.Rows.Clear();
            dataGridViewAll.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewAll.RowCount = tablePersCase.Count;
            for (int i = 0; i < tablePersCase.Count; i++)
            {
                dataGridViewAll.Rows[i].Cells[0].Value = tablePersCase[i].id;
                dataGridViewAll.Rows[i].Cells[1].Value = tablePersCase[i].Num_case;
                dataGridViewAll.Rows[i].Cells[2].Value = tablePersCase[i].Kol_list;
                dataGridViewAll.Rows[i].Cells[3].Value = tablePersCase[i].Form_ob;
                dataGridViewAll.Rows[i].Cells[4].Value = tablePersCase[i].FIO_Stud;
                dataGridViewAll.Rows[i].Cells[5].Value = tablePersCase[i].Groups;
                dataGridViewAll.Rows[i].Cells[6].Value = tablePersCase[i].Srock_Hran;
                dataGridViewAll.Rows[i].Cells[7].Value = tablePersCase[i].Otchis;
                dataGridViewAll.Rows[i].Cells[8].Value = tablePersCase[i].God_N_ob;
                dataGridViewAll.Rows[i].Cells[9].Value = tablePersCase[i].God_O_ob;
                dataGridViewAll.Rows[i].Cells[10].Value = tablePersCase[i].God_N_LD;
                dataGridViewAll.Rows[i].Cells[11].Value = tablePersCase[i].God_O_LD;
                dataGridViewAll.Rows[i].Cells[12].Value = tablePersCase[i].Spesial;
                dataGridViewAll.Rows[i].Cells[13].Value = tablePersCase[i].Num_sh;
                dataGridViewAll.Rows[i].Cells[14].Value = tablePersCase[i].Num_pol;
            }
        }

        public void fillTablePersCaseSort()
        {
            ClassListSort classListsSort = new ClassListSort();
            List<ClassListSort.TablePersCaseSort> tablePersCase = classListsSort.getTablePersCaseSort(textBoxGroup.Text, textBoxFIOS.Text);
            dataGridViewAll.Rows.Clear();
            dataGridViewAll.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewAll.RowCount = tablePersCase.Count;
            for (int i = 0; i < tablePersCase.Count; i++)
            {
                dataGridViewAll.Rows[i].Cells[0].Value = tablePersCase[i].id;
                dataGridViewAll.Rows[i].Cells[1].Value = tablePersCase[i].Num_case;
                dataGridViewAll.Rows[i].Cells[2].Value = tablePersCase[i].Kol_list;
                dataGridViewAll.Rows[i].Cells[3].Value = tablePersCase[i].Form_ob;
                dataGridViewAll.Rows[i].Cells[4].Value = tablePersCase[i].FIO_Stud;
                dataGridViewAll.Rows[i].Cells[5].Value = tablePersCase[i].Groups;
                dataGridViewAll.Rows[i].Cells[6].Value = tablePersCase[i].Srock_Hran;
                dataGridViewAll.Rows[i].Cells[7].Value = tablePersCase[i].Otchis;
                dataGridViewAll.Rows[i].Cells[8].Value = tablePersCase[i].God_N_ob;
                dataGridViewAll.Rows[i].Cells[9].Value = tablePersCase[i].God_O_ob;
                dataGridViewAll.Rows[i].Cells[10].Value = tablePersCase[i].God_N_LD;
                dataGridViewAll.Rows[i].Cells[11].Value = tablePersCase[i].God_O_LD;
                dataGridViewAll.Rows[i].Cells[12].Value = tablePersCase[i].Spesial;
                dataGridViewAll.Rows[i].Cells[13].Value = tablePersCase[i].Num_sh;
                dataGridViewAll.Rows[i].Cells[14].Value = tablePersCase[i].Num_pol;
            }
        }

        public void fillTablePersCaseSroc()
        {
            ClassListSort classListsSort = new ClassListSort();
            List<ClassListSort.TablePersCaseSroc> tablePersCase = classListsSort.getTablePersCaseSroc();
            dataGridViewAll.Rows.Clear();
            dataGridViewAll.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewAll.RowCount = tablePersCase.Count;
            for (int i = 0; i < tablePersCase.Count; i++)
            {
                dataGridViewAll.Rows[i].Cells[0].Value = tablePersCase[i].id;
                dataGridViewAll.Rows[i].Cells[1].Value = tablePersCase[i].Num_case;
                dataGridViewAll.Rows[i].Cells[2].Value = tablePersCase[i].Kol_list;
                dataGridViewAll.Rows[i].Cells[3].Value = tablePersCase[i].Form_ob;
                dataGridViewAll.Rows[i].Cells[4].Value = tablePersCase[i].FIO_Stud;
                dataGridViewAll.Rows[i].Cells[5].Value = tablePersCase[i].Groups;
                dataGridViewAll.Rows[i].Cells[6].Value = tablePersCase[i].Srock_Hran;
                dataGridViewAll.Rows[i].Cells[7].Value = tablePersCase[i].Otchis;
                dataGridViewAll.Rows[i].Cells[8].Value = tablePersCase[i].God_N_ob;
                dataGridViewAll.Rows[i].Cells[9].Value = tablePersCase[i].God_O_ob;
                dataGridViewAll.Rows[i].Cells[10].Value = tablePersCase[i].God_N_LD;
                dataGridViewAll.Rows[i].Cells[11].Value = tablePersCase[i].God_O_LD;
                dataGridViewAll.Rows[i].Cells[12].Value = tablePersCase[i].Spesial;
                dataGridViewAll.Rows[i].Cells[13].Value = tablePersCase[i].Num_sh;
                dataGridViewAll.Rows[i].Cells[14].Value = tablePersCase[i].Num_pol;
            }
        }

        public void fillTableWorkStud()
        {
            ClassListsData classListsData = new ClassListsData();
            List<ClassListsData.TableWorkStud> tableWorkStuds = classListsData.getTableWorkStud();
            dataGridViewAll.Rows.Clear();
            dataGridViewAll.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewAll.RowCount = tableWorkStuds.Count;
            for (int i = 0; i < tableWorkStuds.Count; i++)
            {
                dataGridViewAll.Rows[i].Cells[0].Value = tableWorkStuds[i].id;
                dataGridViewAll.Rows[i].Cells[1].Value = tableWorkStuds[i].Topic;
                dataGridViewAll.Rows[i].Cells[2].Value = tableWorkStuds[i].FIO_stud;
                dataGridViewAll.Rows[i].Cells[3].Value = tableWorkStuds[i].Name_work;
                dataGridViewAll.Rows[i].Cells[4].Value = tableWorkStuds[i].Prof_modul;
                dataGridViewAll.Rows[i].Cells[5].Value = tableWorkStuds[i].Group;
                dataGridViewAll.Rows[i].Cells[6].Value = tableWorkStuds[i].Year;
                dataGridViewAll.Rows[i].Cells[7].Value = tableWorkStuds[i].Num_stel;
                dataGridViewAll.Rows[i].Cells[8].Value = tableWorkStuds[i].Num_pol;
            }
        }

        public void fillTableWorkStudSroc()
        {
            ClassListSort classListSort = new ClassListSort();
            List<ClassListSort.TableWorkStudSroc> tableWorkStuds = classListSort.getTableWorkStudSroc();
            dataGridViewAll.Rows.Clear();
            dataGridViewAll.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewAll.RowCount = tableWorkStuds.Count;
            for (int i = 0; i < tableWorkStuds.Count; i++)
            {
                dataGridViewAll.Rows[i].Cells[0].Value = tableWorkStuds[i].id;
                dataGridViewAll.Rows[i].Cells[1].Value = tableWorkStuds[i].Topic;
                dataGridViewAll.Rows[i].Cells[2].Value = tableWorkStuds[i].FIO_stud;
                dataGridViewAll.Rows[i].Cells[3].Value = tableWorkStuds[i].Name_work;
                dataGridViewAll.Rows[i].Cells[4].Value = tableWorkStuds[i].Prof_modul;
                dataGridViewAll.Rows[i].Cells[5].Value = tableWorkStuds[i].Group;
                dataGridViewAll.Rows[i].Cells[6].Value = tableWorkStuds[i].Year;
                dataGridViewAll.Rows[i].Cells[7].Value = tableWorkStuds[i].Num_stel;
                dataGridViewAll.Rows[i].Cells[8].Value = tableWorkStuds[i].Num_pol;
            }
        }

        public void fillTableWorkStudSearchT()
        {
            ClassListSort classListSort = new ClassListSort();
            List<ClassListSort.TableWorkStudSearchT> tableWorkStuds = classListSort.getTableWorkStudSearchT(textBoxTopic.Text, textBoxGroup.Text, textBoxFIOS.Text);
            dataGridViewAll.Rows.Clear();
            dataGridViewAll.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewAll.RowCount = tableWorkStuds.Count;
            for (int i = 0; i < tableWorkStuds.Count; i++)
            {
                dataGridViewAll.Rows[i].Cells[0].Value = tableWorkStuds[i].id;
                dataGridViewAll.Rows[i].Cells[1].Value = tableWorkStuds[i].Topic;
                dataGridViewAll.Rows[i].Cells[2].Value = tableWorkStuds[i].FIO_stud;
                dataGridViewAll.Rows[i].Cells[3].Value = tableWorkStuds[i].Name_work;
                dataGridViewAll.Rows[i].Cells[4].Value = tableWorkStuds[i].Prof_modul;
                dataGridViewAll.Rows[i].Cells[5].Value = tableWorkStuds[i].Group;
                dataGridViewAll.Rows[i].Cells[6].Value = tableWorkStuds[i].Year;
                dataGridViewAll.Rows[i].Cells[7].Value = tableWorkStuds[i].Num_stel;
                dataGridViewAll.Rows[i].Cells[8].Value = tableWorkStuds[i].Num_pol;
            }
        }

        public void fillTableDestDoc()
        {
            ClassListsData classListsData = new ClassListsData();
            List<ClassListsData.TableDestDoc> tableDestDocs = classListsData.getTableDestDocs();
            dataGridViewAll.Rows.Clear();
            dataGridViewAll.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewAll.RowCount = tableDestDocs.Count;
            for (int i = 0; i < tableDestDocs.Count; i++)
            {
                dataGridViewAll.Rows[i].Cells[0].Value = tableDestDocs[i].id;
                dataGridViewAll.Rows[i].Cells[1].Value = tableDestDocs[i].Vid_Doc;
                dataGridViewAll.Rows[i].Cells[2].Value = tableDestDocs[i].Prichina;
                dataGridViewAll.Rows[i].Cells[3].Value = tableDestDocs[i].Date;
                dataGridViewAll.Rows[i].Cells[4].Value = tableDestDocs[i].FIO_stud;
                dataGridViewAll.Rows[i].Cells[5].Value = tableDestDocs[i].God_N_ob;
                dataGridViewAll.Rows[i].Cells[6].Value = tableDestDocs[i].God_O_ob;
                dataGridViewAll.Rows[i].Cells[7].Value = tableDestDocs[i].Group;
                dataGridViewAll.Rows[i].Cells[8].Value = tableDestDocs[i].Num_LD;
                dataGridViewAll.Rows[i].Cells[9].Value = tableDestDocs[i].Kol_list;
                dataGridViewAll.Rows[i].Cells[10].Value = tableDestDocs[i].Forma_ob;
                dataGridViewAll.Rows[i].Cells[11].Value = tableDestDocs[i].God_N_LD;
                dataGridViewAll.Rows[i].Cells[12].Value = tableDestDocs[i].God_O_LD;
                dataGridViewAll.Rows[i].Cells[13].Value = tableDestDocs[i].KodSP;
                dataGridViewAll.Rows[i].Cells[14].Value = tableDestDocs[i].Name_SP;
                dataGridViewAll.Rows[i].Cells[15].Value = tableDestDocs[i].Qualif;
                dataGridViewAll.Rows[i].Cells[16].Value = tableDestDocs[i].Prof_Mod;
                dataGridViewAll.Rows[i].Cells[17].Value = tableDestDocs[i].Topic;
                dataGridViewAll.Rows[i].Cells[18].Value = tableDestDocs[i].Name_Work;
            }
        }

        public void fillTableDestDocsSearch()
        {
            ClassListSort classListsSort = new ClassListSort();
            List<ClassListSort.TableDestDocSearch> tableDestDocs = classListsSort.getTableDestDocsSearch(textBoxTopic.Text, textBoxGroup.Text, textBoxFIOS.Text);
            dataGridViewAll.Rows.Clear();
            dataGridViewAll.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewAll.RowCount = tableDestDocs.Count;
            for (int i = 0; i < tableDestDocs.Count; i++)
            {
                dataGridViewAll.Rows[i].Cells[0].Value = tableDestDocs[i].id;
                dataGridViewAll.Rows[i].Cells[1].Value = tableDestDocs[i].Vid_Doc;
                dataGridViewAll.Rows[i].Cells[2].Value = tableDestDocs[i].Prichina;
                dataGridViewAll.Rows[i].Cells[3].Value = tableDestDocs[i].Date;
                dataGridViewAll.Rows[i].Cells[4].Value = tableDestDocs[i].FIO_stud;
                dataGridViewAll.Rows[i].Cells[5].Value = tableDestDocs[i].God_N_ob;
                dataGridViewAll.Rows[i].Cells[6].Value = tableDestDocs[i].God_O_ob;
                dataGridViewAll.Rows[i].Cells[7].Value = tableDestDocs[i].Group;
                dataGridViewAll.Rows[i].Cells[8].Value = tableDestDocs[i].Num_LD;
                dataGridViewAll.Rows[i].Cells[9].Value = tableDestDocs[i].Kol_list;
                dataGridViewAll.Rows[i].Cells[10].Value = tableDestDocs[i].Forma_ob;
                dataGridViewAll.Rows[i].Cells[11].Value = tableDestDocs[i].God_N_LD;
                dataGridViewAll.Rows[i].Cells[12].Value = tableDestDocs[i].God_O_LD;
                dataGridViewAll.Rows[i].Cells[13].Value = tableDestDocs[i].KodSP;
                dataGridViewAll.Rows[i].Cells[14].Value = tableDestDocs[i].Name_SP;
                dataGridViewAll.Rows[i].Cells[15].Value = tableDestDocs[i].Qualif;
                dataGridViewAll.Rows[i].Cells[16].Value = tableDestDocs[i].Prof_Mod;
                dataGridViewAll.Rows[i].Cells[17].Value = tableDestDocs[i].Topic;
                dataGridViewAll.Rows[i].Cells[18].Value = tableDestDocs[i].Name_Work;
            }
        }

        public void fillTableTypeWork()
        {
            ClassListsData classListsData = new ClassListsData();
            List<ClassListsData.TableTypeWork> tableTypeWorks = classListsData.getTableTypeWorks();
            dataGridViewAll.Rows.Clear();
            dataGridViewAll.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewAll.RowCount = tableTypeWorks.Count;
            for (int i = 0; i < tableTypeWorks.Count; i++)
            {
                dataGridViewAll.Rows[i].Cells[0].Value = tableTypeWorks[i].id;
                dataGridViewAll.Rows[i].Cells[1].Value = tableTypeWorks[i].NameWork;
                dataGridViewAll.Rows[i].Cells[2].Value = tableTypeWorks[i].Prof_mod;
                dataGridViewAll.Rows[i].Cells[3].Value = tableTypeWorks[i].Group;
                dataGridViewAll.Rows[i].Cells[4].Value = tableTypeWorks[i].Yesr;
                dataGridViewAll.Rows[i].Cells[5].Value = tableTypeWorks[i].NumStel;
                dataGridViewAll.Rows[i].Cells[6].Value = tableTypeWorks[i].NumPol;
            }
        }

        public void fillTableWorkStudSortW()
        {
            ClassListSort classListsSort = new ClassListSort();
            List<ClassListSort.TableDestDocSort> tableWorkStuds = classListsSort.getTableDestDocsSort(checkBoxWorkStud.Checked, checkBoxLD.Checked);
            dataGridViewAll.Rows.Clear();
            dataGridViewAll.DefaultCellStyle.BackColor = Color.FromArgb(222, 242, 222);
            dataGridViewAll.RowCount = tableWorkStuds.Count;
            for (int i = 0; i < tableWorkStuds.Count; i++)
            {
                dataGridViewAll.Rows[i].Cells[0].Value = tableWorkStuds[i].id;
                dataGridViewAll.Rows[i].Cells[1].Value = tableWorkStuds[i].Vid_Doc;
                dataGridViewAll.Rows[i].Cells[2].Value = tableWorkStuds[i].Prichina;
                dataGridViewAll.Rows[i].Cells[3].Value = tableWorkStuds[i].Date;
                dataGridViewAll.Rows[i].Cells[4].Value = tableWorkStuds[i].FIO_stud;
                dataGridViewAll.Rows[i].Cells[5].Value = tableWorkStuds[i].God_N_ob;
                dataGridViewAll.Rows[i].Cells[6].Value = tableWorkStuds[i].God_O_ob;
                dataGridViewAll.Rows[i].Cells[7].Value = tableWorkStuds[i].Group;
                dataGridViewAll.Rows[i].Cells[8].Value = tableWorkStuds[i].Num_LD;
                dataGridViewAll.Rows[i].Cells[9].Value = tableWorkStuds[i].Kol_list;
                dataGridViewAll.Rows[i].Cells[10].Value = tableWorkStuds[i].Forma_ob;
                dataGridViewAll.Rows[i].Cells[11].Value = tableWorkStuds[i].God_N_LD;
                dataGridViewAll.Rows[i].Cells[12].Value = tableWorkStuds[i].God_O_LD;
                dataGridViewAll.Rows[i].Cells[13].Value = tableWorkStuds[i].KodSP;
                dataGridViewAll.Rows[i].Cells[14].Value = tableWorkStuds[i].Name_SP;
                dataGridViewAll.Rows[i].Cells[15].Value = tableWorkStuds[i].Qualif;
                dataGridViewAll.Rows[i].Cells[16].Value = tableWorkStuds[i].Prof_Mod;
                dataGridViewAll.Rows[i].Cells[17].Value = tableWorkStuds[i].Topic;
                dataGridViewAll.Rows[i].Cells[18].Value = tableWorkStuds[i].Name_Work;
            }
        }

        private DataTable GetDataFormDatabase(string query)
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(myConnString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            return dataTable;
        }

        private void ExportToPDFLD(DataTable dataTable, string filePath, List<int> id)
        {
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            document.Open();
            BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font f = new iTextSharp.text.Font(baseFont);

            string reportTitle = "Расположение личных дел студентов в архиве ";
            Paragraph title = new Paragraph(reportTitle, f);
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            document.Add(new Paragraph(" "));

            PdfPTable table = new PdfPTable(5);
            string[] nameStolb = { "Номер личного дела", "ФИО студента", "Специальность", "Стелаж", "Полка" };

            for (int i = 0; i < 5; i++)
            {
                table.AddCell(new Phrase(nameStolb[i], f));
            }
            using (MySqlConnection connection = new MySqlConnection(myConnString))
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                for (int i = 0; i < id.Count; i++)
                {
                    string sql = $"SELECT pc1.Number_personal_del, Student.FIO, Specialization.Qualification, " +
                        $"pc1.Number_Shelf, pc1.Number_polki FROM Student " +
                        $"INNER JOIN Personal_case pc1 ON Student.id_student = pc1.id_student " +
                        $"INNER JOIN Specialization ON Specialization.id_specialization = pc1.id_specialization " +
                        $"WHERE pc1.id_personal_delo = {id[i].ToString()}";
                    cmd.CommandText = sql;
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            table.AddCell(new Phrase(reader.GetInt32(0).ToString(), f));
                            table.AddCell(new Phrase(reader.GetString(1), f));
                            table.AddCell(new Phrase(reader.GetString(2), f));
                            table.AddCell(new Phrase(reader.GetInt32(3).ToString(), f));
                            table.AddCell(new Phrase(reader.GetInt32(4).ToString().ToString(), f));
                        }
                    }
                }
            }
            document.Add(table);
            document.Close();
        }

        private DataTable GetDataFormDatabaseWork(string query)
        {
            DataTable dataTableWork = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(myConnString))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTableWork);
                    }
                }
            }
            return dataTableWork;
        }

        private void ExportToPDFWork(DataTable dataTableWork, string filePath, List<int> id)
        {
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            document.Open();
            BaseFont baseFont = BaseFont.CreateFont("C:\\Windows\\Fonts\\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font f = new iTextSharp.text.Font(baseFont);

            string reportTitle = "Расположение личных дел студентов в архиве ";
            Paragraph title = new Paragraph(reportTitle, f);
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            document.Add(new Paragraph(" "));

            PdfPTable table = new PdfPTable(6);
            string[] nameStolb = { "ФИО\r\nстудента ", "Название\r\nработы", "Группа", "Год", "Стеллаж", "Полка" };

            for (int i = 0; i < 6; i++)
            {
                table.AddCell(new Phrase(nameStolb[i], f));
            }
            using (MySqlConnection connection = new MySqlConnection(myConnString))
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                for (int i = 0; i < id.Count; i++)
                {
                    string sql = $"SELECT Student.FIO, Type_work.Name_work , Work.`Group`, Work.Year, Work.Number_setl, " +
                        $"Work.Number_pol FROM Student " +
                        $"INNER JOIN Work_Stud ON Student.id_student = Work_Stud.id_student " +
                        $"INNER JOIN Work ON Work_Stud.id_work = Work.id_work " +
                        $"INNER JOIN Type_work ON Work.id_type_work = Type_work.id_type_work " +
                        $"WHERE Work_Stud.id_work_stud = {id[i].ToString()};";
                    cmd.CommandText = sql;
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            table.AddCell(new Phrase(reader.GetString(0), f));
                            table.AddCell(new Phrase(reader.GetString(1), f));
                            table.AddCell(new Phrase(reader.GetString(2), f));
                            table.AddCell(new Phrase(reader.GetInt32(3).ToString(), f));
                            table.AddCell(new Phrase(reader.GetInt32(4).ToString(), f));
                            table.AddCell(new Phrase(reader.GetInt32(5).ToString(), f));
                        }
                    }
                }
            }
            document.Add(table);
            document.Close();
        }

        public FormDescktop()
        {
            InitializeComponent();
            toolStripStatusLabelPost.Text = "Должность: " + FormAuthorization.Post;
            toolStripStatusLabelFIOStaff.Text = "ФИО: " + FormAuthorization.Surname + " " + FormAuthorization.NameS + " " + FormAuthorization.Part;

            // Анимация появления окна
            {
                this.Opacity = 0;
                timerAnimation.Tick += new EventHandler((sender, e) =>
                {
                    if ((Opacity += 0.05) == 1)
                        timerAnimation.Stop();
                });
                timerAnimation.Start();
            }

            // Считывание данных из файла config.ini и присваевание данных переменной myConnS

            StreamReader Fileini = new StreamReader("config.ini");
            while ((line = Fileini.ReadLine()) != null)
            {
                myConnString += line + ";";
            }
            Fileini.Close();
            toolStripStatusLabel2.Alignment = ToolStripItemAlignment.Right;
            if (toolStripStatusLabelPost.Text == "Должность: Системный администратор"
                || FormAuthorization.role == "Administrator") { buttonAdmPan.Enabled = true; }
        }

        private void buttonAdmPan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminPanel formAdminPanel = new FormAdminPanel();
            formAdminPanel.ShowDialog();
        }

        private void buttonSpecial_Click(object sender, EventArgs e)
        {
            {
                if (FormAuthorization.role == "`User`")
                {
                    добавитьСпециальностьToolStripMenuItem.Visible = false;
                    редактироватьСпециальностьToolStripMenuItem.Visible = false;
                    удалитьСпециальностьToolStripMenuItem.Visible = false;

                    pictureBoxImport.Visible = false;
                    pictureBox3.Visible = false;
                }
                else
                {
                    pictureBox3.Visible = false;
                    checkBoxLD.Visible = false;

                    pictureBoxImport.Visible = false;
                    checkBoxWorkStud.Visible = false;
                    добавитьСпециальностьToolStripMenuItem.Visible = true;
                    редактироватьСпециальностьToolStripMenuItem.Visible = true;
                    удалитьСпециальностьToolStripMenuItem.Visible = true;

                    добавитьЛичноеДелоСтудентаToolStripMenuItem.Visible = false;
                    редактироватьЛичноеДелоСтудентаToolStripMenuItem.Visible = false;
                    удалитьЛичноеДелоToolStripMenuItem.Visible = false;

                    добавитьРаботуСтудентаToolStripMenuItem.Visible = false;
                    редактироватьРаботуСтудентаToolStripMenuItem.Visible = false;
                    удалитьРаботуСтудентаToolStripMenuItem.Visible = false;

                    добавитьТипРаботыToolStripMenuItem.Visible = false;
                    редактироватьТипРаботыToolStripMenuItem.Visible = false;
                    удалитьТипРаботыToolStripMenuItem.Visible = false;

                    добавитьВидРаботыToolStripMenuItem.Visible = false;
                    редактироватьВидРаботыToolStripMenuItem.Visible = false;
                    удалитьВидРаботыToolStripMenuItem.Visible = false;


                    pictureBoxImport.Visible = false;
                    checkBoxLD.Visible = false;
                    checkBoxWorkStud.Visible = false;

                    panel2.Visible = true;
                    pictureBox3.Visible = false;
                    checkBoxSroc.Visible = false;
                    splitContainer1.Visible = true;
                }
                labelText.Text = "Список специальностей";

                // Очистка столбцов dataGridViewAll, после чего добавление новых столбцов
                dataGridViewAll.Columns.Clear();
                dataGridViewAll.Columns.Add("id", "ID");
                dataGridViewAll.Columns.Add("kod", "Код");
                dataGridViewAll.Columns.Add("name", "Название специальности");
                dataGridViewAll.Columns.Add("qualification", "Квалификация");
                dataGridViewAll.Columns[0].Visible = false;
                dataGridViewAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            fillTableSpec();
        }

        private void buttonLichDel_Click(object sender, EventArgs e)
        {
            {
                if (FormAuthorization.role == "`User`")
                {
                    добавитьЛичноеДелоСтудентаToolStripMenuItem.Visible = false;
                    редактироватьЛичноеДелоСтудентаToolStripMenuItem.Visible = false;
                    удалитьЛичноеДелоToolStripMenuItem.Visible = false;
                    pictureBoxImport.Visible = true;
                }
                else
                {
                    checkBoxLD.Visible = false;
                    checkBoxWorkStud.Visible = false;
                    добавитьЛичноеДелоСтудентаToolStripMenuItem.Visible = true;
                    редактироватьЛичноеДелоСтудентаToolStripMenuItem.Visible = true;
                    удалитьЛичноеДелоToolStripMenuItem.Visible = true;
                    добавитьСпециальностьToolStripMenuItem.Visible = false;
                    редактироватьСпециальностьToolStripMenuItem.Visible = false;
                    добавитьРаботуСтудентаToolStripMenuItem.Visible = false;
                    редактироватьРаботуСтудентаToolStripMenuItem.Visible = false;

                    добавитьВидРаботыToolStripMenuItem.Visible = false;
                    редактироватьВидРаботыToolStripMenuItem.Visible = false;
                    удалитьВидРаботыToolStripMenuItem.Visible = false;
                    удалитьСпециальностьToolStripMenuItem.Visible = false;
                    удалитьРаботуСтудентаToolStripMenuItem.Visible = false;

                    добавитьТипРаботыToolStripMenuItem.Visible = false;
                    редактироватьТипРаботыToolStripMenuItem.Visible = false;
                    удалитьТипРаботыToolStripMenuItem.Visible = false;


                    pictureBoxImport.Visible = true;
                    checkBoxLD.Visible = false;
                    checkBoxWorkStud.Visible = false;

                    panel2.Visible = true;
                    pictureBox3.Visible = true;
                    checkBoxSroc.Visible = true;
                    splitContainer1.Visible = true;
                    textBoxTopic.Visible = false;
                    labelTopic.Visible = false;
                }
                labelText.Text = "Личные дела студентов";

                // Очистка столбцов dataGridViewAll, после чего добавление новых столбцов
                dataGridViewAll.Columns.Clear();
                dataGridViewAll.Columns.Add("id", "ID");
                dataGridViewAll.Columns.Add("Number_personal_del", "Номер личного дела");
                dataGridViewAll.Columns.Add("Kolichestvo_list", "Кол-во листов");
                dataGridViewAll.Columns.Add("form_obuch", "Форма обучения");
                dataGridViewAll.Columns.Add("FIO", "ФИО студента");
                dataGridViewAll.Columns.Add("Group", "Группа");
                dataGridViewAll.Columns.Add("Srock_Hraneniya", "Срок хранения");
                dataGridViewAll.Columns.Add("Expelled", "Отчислен");
                dataGridViewAll.Columns.Add("God_Nach_LD", "Год заведения личного дела");
                dataGridViewAll.Columns.Add("God_ocon_LD", "Год закрытия личного дела");
                dataGridViewAll.Columns.Add("God_nach_obuch", "Год поступления");
                dataGridViewAll.Columns.Add("God_ocon_obuch", "Год отчисления");
                dataGridViewAll.Columns.Add("Ыpecialization", "Специальность");
                dataGridViewAll.Columns.Add("Number_Shelf", "Номер стилажа");
                dataGridViewAll.Columns.Add("Number_polki", "Номер полки");
                dataGridViewAll.Columns[0].Visible = false;
                dataGridViewAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            fillTablePersCase();
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            {
                {
                    checkBoxLD.Visible = false;
                    checkBoxWorkStud.Visible = false;
                    pictureBoxImport.Visible = true;
                    добавитьСпециальностьToolStripMenuItem.Visible = false;
                    редактироватьСпециальностьToolStripMenuItem.Visible = false;
                    удалитьСпециальностьToolStripMenuItem.Visible = false;

                    добавитьЛичноеДелоСтудентаToolStripMenuItem.Visible = false;
                    редактироватьЛичноеДелоСтудентаToolStripMenuItem.Visible = false;
                    удалитьЛичноеДелоToolStripMenuItem.Visible = false;

                    добавитьРаботуСтудентаToolStripMenuItem.Visible = false;
                    редактироватьРаботуСтудентаToolStripMenuItem.Visible = false;
                    удалитьРаботуСтудентаToolStripMenuItem.Visible = false;

                    добавитьТипРаботыToolStripMenuItem.Visible = false;
                    редактироватьТипРаботыToolStripMenuItem.Visible = false;
                    удалитьТипРаботыToolStripMenuItem.Visible = false;

                    добавитьВидРаботыToolStripMenuItem.Visible = false;
                    редактироватьВидРаботыToolStripMenuItem.Visible = false;
                    удалитьВидРаботыToolStripMenuItem.Visible = false;


                    pictureBoxImport.Visible = false;


                    checkBoxLD.Visible = false;
                    checkBoxWorkStud.Visible = false;

                    panel2.Visible = true;
                    pictureBox3.Visible = true;
                    checkBoxSroc.Visible = false;

                    labelGroup.Visible = true;
                    textBoxGroup.Visible = true;

                    labelTopic.Visible = false;
                    textBoxTopic.Visible = false;

                    splitContainer1.Visible = true;
                }
                labelText.Text = "Список студентов техникума";

                // Очистка столбцов dataGridViewAll, после чего добавление новых столбцов
                dataGridViewAll.Columns.Clear();
                dataGridViewAll.Columns.Add("id", "ID");
                dataGridViewAll.Columns.Add("FIO", "Фамилия, имя, отчество");
                dataGridViewAll.Columns.Add("Group", "Группа");
                dataGridViewAll.Columns.Add("God_nach_ob", "Год начала обучения");
                dataGridViewAll.Columns[0].Visible = false;
                dataGridViewAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            fillTableStud();
        }

        private void buttonWorkStud_Click(object sender, EventArgs e)
        {
            {
                if (FormAuthorization.role == "`User`")
                {
                    добавитьРаботуСтудентаToolStripMenuItem.Visible = false;
                    редактироватьРаботуСтудентаToolStripMenuItem.Visible = false;
                    удалитьРаботуСтудентаToolStripMenuItem.Visible = false;
                    pictureBoxImport.Visible = true;
                }
                else
                {
                    checkBoxLD.Visible = false;
                    checkBoxWorkStud.Visible = false;
                    добавитьРаботуСтудентаToolStripMenuItem.Visible = true;
                    редактироватьРаботуСтудентаToolStripMenuItem.Visible = true;
                    удалитьРаботуСтудентаToolStripMenuItem.Visible = true;

                    добавитьЛичноеДелоСтудентаToolStripMenuItem.Visible = false;
                    редактироватьЛичноеДелоСтудентаToolStripMenuItem.Visible = false;
                    удалитьЛичноеДелоToolStripMenuItem.Visible = false;


                    добавитьСпециальностьToolStripMenuItem.Visible = false;
                    редактироватьСпециальностьToolStripMenuItem.Visible = false;
                    удалитьСпециальностьToolStripMenuItem.Visible = false;

                    добавитьВидРаботыToolStripMenuItem.Visible = false;
                    редактироватьВидРаботыToolStripMenuItem.Visible = false;
                    удалитьВидРаботыToolStripMenuItem.Visible = false;

                    добавитьТипРаботыToolStripMenuItem.Visible = false;
                    редактироватьТипРаботыToolStripMenuItem.Visible = false;
                    удалитьТипРаботыToolStripMenuItem.Visible = false;


                    pictureBoxImport.Visible = true;
                    checkBoxLD.Visible = false;
                    checkBoxWorkStud.Visible = false;

                    checkBoxSroc.Visible = true;
                    panel2.Visible = true;
                    pictureBox3.Visible = true;
                    labelGroup.Visible = true;
                    labelTopic.Visible = true;
                    textBoxGroup.Visible = true;
                    textBoxTopic.Visible = true;
                    splitContainer1.Visible = true;
                    textBoxTopic.Visible = true;
                    labelTopic.Visible = true;
                }
                labelText.Text = "Список работ студентов";

                // Очистка столбцов dataGridViewAll, после чего добавление новых столбцов
                dataGridViewAll.Columns.Clear();
                dataGridViewAll.Columns.Add("id", "ID");
                dataGridViewAll.Columns.Add("Topic", "Тема работы");
                dataGridViewAll.Columns.Add("FIO", "ФИО студента");
                dataGridViewAll.Columns.Add("Name_work", "Название работы");
                dataGridViewAll.Columns.Add("Professional_module", "Проф. модуль");
                dataGridViewAll.Columns.Add("Group", "Группа");
                dataGridViewAll.Columns.Add("Year", "Год");
                dataGridViewAll.Columns.Add("Number_setl", "Номер стилажа");
                dataGridViewAll.Columns.Add("Number_pol", "Номер полки");
                dataGridViewAll.Columns[0].Visible = false;
                dataGridViewAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            fillTableWorkStud();
        }

        private void buttonTypeWork_Click(object sender, EventArgs e)
        {
            {
                if (FormAuthorization.role == "`User`")
                {
                    добавитьВидРаботыToolStripMenuItem.Visible = false;
                    редактироватьВидРаботыToolStripMenuItem.Visible = false;
                    удалитьВидРаботыToolStripMenuItem.Visible = false;
                    pictureBox3.Visible = false;

                    pictureBoxImport.Visible = false;
                }
                else
                {

                    pictureBoxImport.Visible = false;
                    pictureBox3.Visible = false;
                    checkBoxLD.Visible = false;
                    checkBoxWorkStud.Visible = false;
                    добавитьВидРаботыToolStripMenuItem.Visible = true;
                    редактироватьВидРаботыToolStripMenuItem.Visible = true;
                    удалитьВидРаботыToolStripMenuItem.Visible = true;

                    добавитьСпециальностьToolStripMenuItem.Visible = false;
                    редактироватьСпециальностьToolStripMenuItem.Visible = false;
                    удалитьСпециальностьToolStripMenuItem.Visible = false;

                    добавитьРаботуСтудентаToolStripMenuItem.Visible = false;
                    редактироватьРаботуСтудентаToolStripMenuItem.Visible = false;
                    удалитьРаботуСтудентаToolStripMenuItem.Visible = false;

                    добавитьЛичноеДелоСтудентаToolStripMenuItem.Visible = false;
                    редактироватьЛичноеДелоСтудентаToolStripMenuItem.Visible = false;
                    удалитьЛичноеДелоToolStripMenuItem.Visible = false;

                    добавитьТипРаботыToolStripMenuItem.Visible = false;
                    редактироватьТипРаботыToolStripMenuItem.Visible = false;
                    удалитьТипРаботыToolStripMenuItem.Visible = false;


                    pictureBoxImport.Visible = false;
                    checkBoxLD.Visible = false;
                    checkBoxWorkStud.Visible = false;

                    checkBoxSroc.Visible = true;
                    pictureBox3.Visible = false;
                    panel2.Visible = true;
                    splitContainer1.Visible = true;
                    checkBoxSroc.Visible = false;
                }
                labelText.Text = "Список работ";

                // Очистка столбцов dataGridViewAll, после чего добавление новых столбцов
                dataGridViewAll.Columns.Clear();
                dataGridViewAll.Columns.Add("id", "ID");
                dataGridViewAll.Columns.Add("Name_work", "Название работы");
                dataGridViewAll.Columns[0].Visible = false;
                dataGridViewAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            fillTableVidWork();
        }

        private void buttonTypeWork_Click_1(object sender, EventArgs e)
        {
            {
                if (FormAuthorization.role == "`User`")
                {
                    редактироватьТипРаботыToolStripMenuItem.Visible = false;
                    добавитьТипРаботыToolStripMenuItem.Visible = false;
                    удалитьТипРаботыToolStripMenuItem.Visible = false;
                    pictureBox3.Visible = false;

                    pictureBoxImport.Visible = false;
                }
                else
                {
                    pictureBox3.Visible = false;
                    checkBoxLD.Visible = false;

                    pictureBoxImport.Visible = false;
                    checkBoxWorkStud.Visible = false;
                    редактироватьТипРаботыToolStripMenuItem.Visible = true;
                    добавитьТипРаботыToolStripMenuItem.Visible = true;
                    удалитьТипРаботыToolStripMenuItem.Visible = true;

                    добавитьСпециальностьToolStripMenuItem.Visible = false;
                    редактироватьСпециальностьToolStripMenuItem.Visible = false;
                    удалитьСпециальностьToolStripMenuItem.Visible = false;

                    добавитьРаботуСтудентаToolStripMenuItem.Visible = false;
                    редактироватьРаботуСтудентаToolStripMenuItem.Visible = false;
                    удалитьРаботуСтудентаToolStripMenuItem.Visible = false;

                    добавитьВидРаботыToolStripMenuItem.Visible = false;
                    редактироватьВидРаботыToolStripMenuItem.Visible = false;
                    удалитьВидРаботыToolStripMenuItem.Visible = false;

                    добавитьЛичноеДелоСтудентаToolStripMenuItem.Visible = false;
                    редактироватьЛичноеДелоСтудентаToolStripMenuItem.Visible = false;
                    удалитьЛичноеДелоToolStripMenuItem.Visible = false;


                    panel2.Visible = true;
                    pictureBox3.Visible = false;
                    checkBoxSroc.Visible = false;
                    splitContainer1.Visible = true;
                }
                labelText.Text = "Список типов работ";

                dataGridViewAll.Columns.Clear();
                dataGridViewAll.Columns.Add("id", "ID");
                dataGridViewAll.Columns.Add("Vid_documentd", "Вид работы");
                dataGridViewAll.Columns.Add("Prichina_Unich", "Профессиональный мдуль");
                dataGridViewAll.Columns.Add("Date_unich", "Группа");
                dataGridViewAll.Columns.Add("FIO", "Год");
                dataGridViewAll.Columns.Add("God_ocon", "Номер стилажа");
                dataGridViewAll.Columns.Add("God_nach_obuch", "Номер полки");
                dataGridViewAll.Columns[0].Visible = false;
                dataGridViewAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            fillTableTypeWork();

        }

        private void buttonDelDoc_Click(object sender, EventArgs e)
        {
            {
                добавитьСпециальностьToolStripMenuItem.Visible = false;
                редактироватьСпециальностьToolStripMenuItem.Visible = false;
                удалитьСпециальностьToolStripMenuItem.Visible = false;

                добавитьРаботуСтудентаToolStripMenuItem.Visible = false;
                редактироватьРаботуСтудентаToolStripMenuItem.Visible = false;
                удалитьРаботуСтудентаToolStripMenuItem.Visible = false;

                добавитьЛичноеДелоСтудентаToolStripMenuItem.Visible = false;
                редактироватьЛичноеДелоСтудентаToolStripMenuItem.Visible = false;
                удалитьЛичноеДелоToolStripMenuItem.Visible = false;


                добавитьВидРаботыToolStripMenuItem.Visible = false;
                редактироватьВидРаботыToolStripMenuItem.Visible = false;
                удалитьВидРаботыToolStripMenuItem.Visible = false;

                добавитьТипРаботыToolStripMenuItem.Visible = false;
                редактироватьТипРаботыToolStripMenuItem.Visible = false;
                удалитьТипРаботыToolStripMenuItem.Visible = false;


                pictureBoxImport.Visible = false;
                checkBoxLD.Visible = true;
                checkBoxWorkStud.Visible = true;

                pictureBoxImport.Visible = false;
                checkBoxSroc.Visible = false;
                pictureBox3.Visible = true;
                panel2.Visible = true;
                splitContainer1.Visible = true;
                labelText.Text = "Список утелизированных документов с истекшим сроком хранения";
                // Очистка столбцов dataGridViewAll, после чего добавление новых столбцов
                dataGridViewAll.Columns.Clear();
                dataGridViewAll.Columns.Add("id", "ID");
                dataGridViewAll.Columns.Add("Vid_documentd", "Вид документа");
                dataGridViewAll.Columns.Add("Prichina_Unich", "Причина утилизации");
                dataGridViewAll.Columns.Add("Date_unich", "Дата утилизации");
                dataGridViewAll.Columns.Add("FIO", "ФИО студента");
                dataGridViewAll.Columns.Add("God_nach_obuch", "Год поступления");
                dataGridViewAll.Columns.Add("God_ocon", "Год отчисления");
                dataGridViewAll.Columns.Add("Group", "Группа");
                dataGridViewAll.Columns.Add("Namber_personal_del", "Номер личного дела");
                dataGridViewAll.Columns.Add("Kolichestvo_list", "Кол-во листов");
                dataGridViewAll.Columns.Add("Form_obuch", "Форма обучения");
                dataGridViewAll.Columns.Add("God_nach_LD", "Год открытия личного дела");
                dataGridViewAll.Columns.Add("God_ocon_LD", "Год закрытия личного дела");
                dataGridViewAll.Columns.Add("Kod", "Код специальности");
                dataGridViewAll.Columns.Add("Name_spec", "Название специальности");
                dataGridViewAll.Columns.Add("Qualification", "Квалификация");
                dataGridViewAll.Columns.Add("Professional_module", "Профессиональный модуль");
                dataGridViewAll.Columns.Add("Topic", "Тема работы");
                dataGridViewAll.Columns.Add("Name_work", "Название работы");
                dataGridViewAll.Columns[0].Visible = false;
                dataGridViewAll.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            fillTableDestDoc();
        }

        private void добавитьЛичноеДелоСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddUpdLichDelo formAddUpdLichDelo = new FormAddUpdLichDelo();
            formAddUpdLichDelo.checkBox.Enabled = false;
            formAddUpdLichDelo.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    sql = "SELECT Name FROM Specialization";
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    formAddUpdLichDelo.comboBox1.Items.Clear();
                    while (reader.Read())
                    {
                        formAddUpdLichDelo.comboBox1.Items.Add(reader["Name"].ToString());
                    }
                    reader.Close();

                    if (formAddUpdLichDelo.ShowDialog() == DialogResult.OK)
                    {
                        sql = "INSERT INTO Student (id_student, FIO, God_nach_ob, `Group`, God_ocon) " +
                        "VALUES(NULL, '" + formAddUpdLichDelo.textBoxFIOStud.Text +
                        "','" + formAddUpdLichDelo.textBoxGodNachObuch.Text +
                        "','" + formAddUpdLichDelo.textBoxGroup.Text +
                        "','" + formAddUpdLichDelo.textBoxGodOconObuch.Text + "')";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();

                        int idStud;
                        sql = "SELECT LAST_INSERT_ID();";
                        cmd = new MySqlCommand(sql, conn);
                        idStud = Convert.ToInt32(cmd.ExecuteScalar());

                        int idSpec;
                        sql = "SELECT id_specialization FROM Specialization WHERE Name= '" + formAddUpdLichDelo.comboBox1.Text + "'";
                        cmd = new MySqlCommand(sql, conn);
                        idSpec = Convert.ToInt32(cmd.ExecuteScalar());

                        sql = "INSERT INTO Personal_case (id_personal_delo, Number_personal_del, Kolichestvo_list, " +
                            "form_obuch, Srock_Hraneniya, Number_Shelf, Number_polki, Expelled, id_student, God_Nach_LD, " +
                            "God_ocon_LD, God_nach_obuch, God_ocon_obuch, id_specialization) " +
                            "VALUES (NULL, '" + formAddUpdLichDelo.textBoxNumberLichDela.Text +
                            "','" + formAddUpdLichDelo.textBoxKolList.Text + "','" + formAddUpdLichDelo.labelForma.Text +
                            "','" + formAddUpdLichDelo.textBoxSrockHran.Text + "','" + formAddUpdLichDelo.textBoxNamStel.Text +
                            "','" + formAddUpdLichDelo.textBoxNamPolc.Text + "','" + formAddUpdLichDelo.Otchislen +
                            "','" + idStud + "','" + formAddUpdLichDelo.textBoxGodNachLD.Text + "','" + formAddUpdLichDelo.textBoxGodOconLD.Text +
                            "','" + formAddUpdLichDelo.textBoxGodNachObuch.Text + "','" + formAddUpdLichDelo.textBoxGodOconObuch.Text +
                            "','" + idSpec + "')";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Вы успешно добавили новое личное дело студента",
                            "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        fillTablePersCase();
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("В данный момент сервер находится в нерабочем состоянии.\r\nОбратитесь к системному администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 1049)
                {
                    MessageBox.Show("Отсутствует база данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void редактироватьЛичноеДелоСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddUpdLichDelo formAddUpdLichDelo = new FormAddUpdLichDelo();
            formAddUpdLichDelo.labelINFO.Text = "Редактирование информации личного дела студента";
            formAddUpdLichDelo.checkBox.Enabled = true;
            formAddUpdLichDelo.comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    if (dataGridViewAll.Rows.Count > 0)
                    {
                        sql = "SELECT Name FROM Specialization";
                        cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        formAddUpdLichDelo.comboBox1.Items.Clear();
                        while (reader.Read())
                        {
                            formAddUpdLichDelo.comboBox1.Items.Add(reader["Name"].ToString());
                        }
                        reader.Close();

                        int indRow = dataGridViewAll.CurrentRow.Index;
                        int idLD = Convert.ToInt32(dataGridViewAll.Rows[indRow].Cells[0].Value);
                        string formsO = dataGridViewAll.Rows[indRow].Cells[3].Value.ToString();
                        if (formsO == "Очная")
                        { formAddUpdLichDelo.radioButtonOchno.Checked = true; }
                        else
                        {
                            if (formsO == "Заочная")
                            { formAddUpdLichDelo.radioButtonZaOchno.Checked = true; }
                            else { formAddUpdLichDelo.radioButtonOchZaoch.Checked = true; }
                        }
                        string otchs = dataGridViewAll.Rows[indRow].Cells[8].Value.ToString();
                        if (otchs == "Да") { formAddUpdLichDelo.checkBox.Checked = true; } else { formAddUpdLichDelo.checkBox.Checked = false; }

                        formAddUpdLichDelo.textBoxNumberLichDela.Text = dataGridViewAll.Rows[indRow].Cells[1].Value.ToString();
                        formAddUpdLichDelo.textBoxKolList.Text = dataGridViewAll.Rows[indRow].Cells[2].Value.ToString();
                        formAddUpdLichDelo.textBoxSrockHran.Text = dataGridViewAll.Rows[indRow].Cells[6].Value.ToString();
                        formAddUpdLichDelo.textBoxFIOStud.Text = dataGridViewAll.Rows[indRow].Cells[4].Value.ToString();
                        formAddUpdLichDelo.textBoxGodNachLD.Text = dataGridViewAll.Rows[indRow].Cells[9].Value.ToString();
                        formAddUpdLichDelo.textBoxGodOconLD.Text = dataGridViewAll.Rows[indRow].Cells[9].Value.ToString();
                        formAddUpdLichDelo.textBoxGodNachObuch.Text = dataGridViewAll.Rows[indRow].Cells[10].Value.ToString();
                        formAddUpdLichDelo.textBoxGodOconObuch.Text = dataGridViewAll.Rows[indRow].Cells[11].Value.ToString();
                        formAddUpdLichDelo.comboBox1.Text = dataGridViewAll.Rows[indRow].Cells[12].Value.ToString();
                        formAddUpdLichDelo.textBoxGroup.Text = dataGridViewAll.Rows[indRow].Cells[5].Value.ToString();
                        formAddUpdLichDelo.textBoxNamStel.Text = dataGridViewAll.Rows[indRow].Cells[13].Value.ToString();
                        formAddUpdLichDelo.textBoxNamPolc.Text = dataGridViewAll.Rows[indRow].Cells[14].Value.ToString();

                        if (formAddUpdLichDelo.ShowDialog() == DialogResult.OK)
                        {
                            int idStud;
                            sql = "SELECT id_student FROM Student WHERE FIO= '" + formAddUpdLichDelo.textBoxFIOStud.Text + "'";
                            cmd = new MySqlCommand(sql, conn);
                            idStud = Convert.ToInt32(cmd.ExecuteScalar());

                            int idSpec;
                            sql = "SELECT id_specialization FROM Specialization WHERE Name= '" + formAddUpdLichDelo.comboBox1.Text + "'";
                            cmd = new MySqlCommand(sql, conn);
                            idSpec = Convert.ToInt32(cmd.ExecuteScalar());

                            sql = "UPDATE Personal_case SET " +
                                "Number_personal_del = '" + formAddUpdLichDelo.textBoxNumberLichDela.Text +
                                "', Kolichestvo_list= '" + formAddUpdLichDelo.textBoxKolList.Text +
                                "', form_obuch = '" + formAddUpdLichDelo.labelForma.Text +
                                "', Srock_Hraneniya = '" + formAddUpdLichDelo.textBoxSrockHran.Text +
                                "', Number_Shelf = '" + formAddUpdLichDelo.textBoxNamStel.Text +
                                "', Number_polki = '" + formAddUpdLichDelo.textBoxNamPolc.Text +
                                "', Expelled = '" + formAddUpdLichDelo.Otchislen +
                                "', id_student = '" + idStud + "', God_Nach_LD = '" + formAddUpdLichDelo.textBoxGodNachLD.Text +
                                "', God_ocon_LD = '" + formAddUpdLichDelo.textBoxGodOconLD.Text +
                                "', God_nach_obuch = '" + formAddUpdLichDelo.textBoxGodNachObuch.Text +
                                "', God_ocon_obuch = '" + formAddUpdLichDelo.textBoxGodOconObuch.Text +
                                "', id_specialization = '" + idSpec + "' WHERE id_personal_delo = '" + idLD + "'";
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            fillTablePersCase();
                            MessageBox.Show("Вы успешно отредактировали личное дело студента",
                                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невыбрано личное дело студента для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("В данный момент сервер находится в нерабочем состоянии.\r\nОбратитесь к системному администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 1049)
                {
                    MessageBox.Show("Отсутствует база данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void удалитьЛичноеДелоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    if (dataGridViewAll.Rows.Count > 0)
                    {
                        DialogResult DRDellPC = MessageBox.Show("Вы уверены, что хотите удалить личное дело?",
                            "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (DRDellPC == DialogResult.Yes)
                        {
                            int indRow = dataGridViewAll.CurrentRow.Index;
                            int idPC = Convert.ToInt32(dataGridViewAll.Rows[indRow].Cells[0].Value);
                            string spec = dataGridViewAll.Rows[indRow].Cells[11].Value.ToString();
                            string FIO = dataGridViewAll.Rows[indRow].Cells[6].Value.ToString();
                            sql = "START TRANSACTION;" +
                                "INSERT INTO Destruction_of_documents(Prichina_Unich, Date_unich, FIO, God_nach_obuch, God_ocon, `Group`," +
                                "Namber_personal_del, Kolichestvo_list, Form_obuch, God_nach_LD, God_ocon_LD, Kod, Name_spec, Qualification," +
                                "Professional_module, Topic, Name_work, Vid_documentd, Expelled) " +
                                "SELECT 'Истечение срока хранения' AS Prichina_Unich, DATEformAuthorizationAT(NOW(), '%d.%m.%Y') AS Date_unich," +
                                "(SELECT FIO FROM Student WHERE id_student = p.id_student) AS FIO, p.God_nach_obuch, p.God_ocon_obuch," +
                                "(SELECT `Group` FROM Student WHERE Student.id_student = p.id_student) `AS Group`," +
                                "p.Number_personal_del,p.Kolichestvo_list, p.form_obuch, p.God_Nach_LD, p.God_ocon_LD," +
                                "(SELECT Kod FROM Specialization WHERE Name = '" + spec + "') AS Kod," +
                                "(SELECT Name FROM Specialization WHERE Name = '" + spec + "') AS Name_spec," +
                                "(SELECT Qualification FROM Specialization WHERE Name = '" + spec + "') AS Qualification," +
                                "'', '', '', 'Личное дело' AS Vid_documentd, 'Да'" +
                                "FROM Personal_case p WHERE p.id_personal_delo = '" + idPC + "';" +
                                "DELETE FROM Personal_case WHERE id_personal_delo = '" + idPC + "';" +
                                "COMMIT;";
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            sql = "DELETE FROM Student WHERE FIO ='" + FIO + "'";
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            fillTablePersCase();
                            MessageBox.Show("Личное дело студента успешно перенесено в архив и удалено из списка личных дел студентов.",
                                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Не выбрано личное дело для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("В данный момент сервер находится в нерабочем состоянии." +
                        "\r\nОбратитесь к системному администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 1049)
                {
                    MessageBox.Show("Отсутствует база данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Невозможно удалить личное дело студента, так как у него есть не удаленные работы!",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void добавитьТипРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddUpdWork1 formAddUpdTypeWork = new FormAddUpdWork1();
            formAddUpdTypeWork.comboBoxTypeWork.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    sql = "SELECT Name_work FROM Type_work";
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    formAddUpdTypeWork.comboBoxTypeWork.Items.Clear();
                    while (reader.Read())
                    {
                        formAddUpdTypeWork.comboBoxTypeWork.Items.Add(reader["Name_work"].ToString());
                    }
                    reader.Close();

                    if (formAddUpdTypeWork.ShowDialog() == DialogResult.OK)
                    {
                        int idType;
                        sql = "SELECT id_type_work FROM Type_work WHERE Name_work= '" + formAddUpdTypeWork.comboBoxTypeWork.Text + "'";
                        cmd = new MySqlCommand(sql, conn);
                        idType = Convert.ToInt32(cmd.ExecuteScalar());

                        sql = "INSERT INTO Work (id_work, id_type_work, Number_setl, Number_pol, Professional_module, `Group`, `Year`) " +
                            "VALUES (NULL, '" + idType + "','" + formAddUpdTypeWork.textBoxNumStil.Text + "','"
                            + formAddUpdTypeWork.textBoxNumPol.Text + "','" + formAddUpdTypeWork.textBoxProfMod.Text +
                            "','" + formAddUpdTypeWork.textBoxGroup.Text + "','" + formAddUpdTypeWork.textBoxGod.Text + "')";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        fillTableTypeWork();
                        MessageBox.Show("Вы успешно добавили новый тип работы.",
                            "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("В данный момент сервер находится в нерабочем состоянии.\r\nОбратитесь к системному администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 1049)
                {
                    MessageBox.Show("Отсутствует база данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void редактироватьТипРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddUpdWork1 formAddUpdTypeWork = new FormAddUpdWork1();
            formAddUpdTypeWork.labelINFO.Text = "Редактировать данные о типе работы";
            formAddUpdTypeWork.comboBoxTypeWork.DropDownStyle = ComboBoxStyle.DropDown;
            try
            {
                if (dataGridViewAll.Rows.Count > 0)
                {
                    using (MySqlConnection conn = new MySqlConnection(myConnString))
                    {
                        conn.Open();
                        sql = "SELECT Name_work FROM Type_work";
                        cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader reader;
                        reader = cmd.ExecuteReader();
                        formAddUpdTypeWork.comboBoxTypeWork.Items.Clear();
                        while (reader.Read())
                        {
                            formAddUpdTypeWork.comboBoxTypeWork.Items.Add(reader["Name_work"].ToString());
                        }
                        reader.Close();

                        int indRow = dataGridViewAll.CurrentRow.Index;
                        int idTW = Convert.ToInt32(dataGridViewAll.Rows[indRow].Cells[0].Value);

                        formAddUpdTypeWork.comboBoxTypeWork.Text = dataGridViewAll.Rows[indRow].Cells[1].Value.ToString();
                        formAddUpdTypeWork.textBoxProfMod.Text = dataGridViewAll.Rows[indRow].Cells[2].Value.ToString();
                        formAddUpdTypeWork.textBoxGroup.Text = dataGridViewAll.Rows[indRow].Cells[3].Value.ToString();
                        formAddUpdTypeWork.textBoxGod.Text = dataGridViewAll.Rows[indRow].Cells[4].Value.ToString();
                        formAddUpdTypeWork.textBoxNumStil.Text = dataGridViewAll.Rows[indRow].Cells[5].Value.ToString();
                        formAddUpdTypeWork.textBoxNumPol.Text = dataGridViewAll.Rows[indRow].Cells[6].Value.ToString();

                        if (formAddUpdTypeWork.ShowDialog() == DialogResult.OK)
                        {
                            int idType;
                            sql = "SELECT id_type_work FROM Type_work WHERE Name_work= '" + formAddUpdTypeWork.comboBoxTypeWork.Text + "'";
                            cmd = new MySqlCommand(sql, conn);
                            idType = Convert.ToInt32(cmd.ExecuteScalar());

                            sql = "UPDATE Work SET " +
                                "id_type_work = '" + idType +
                                "', Number_setl = '" + formAddUpdTypeWork.textBoxNumStil.Text +
                                "', Number_pol = '" + formAddUpdTypeWork.textBoxNumPol.Text +
                                "', Professional_module = '" + formAddUpdTypeWork.textBoxProfMod.Text +
                                "', `Group` = '" + formAddUpdTypeWork.textBoxGroup.Text +
                                "', `Year` = '" + formAddUpdTypeWork.textBoxGod.Text + "' WHERE id_work = '" + idTW + "'";
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            fillTableTypeWork();
                            MessageBox.Show("Вы успешно отредактировали тип работы.",
                                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Невыбран тип работы для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("В данный момент сервер находится в нерабочем состоянии.\r\nОбратитесь к системному администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 1049)
                {
                    MessageBox.Show("Отсутствует база данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void удалитьТипРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    if (dataGridViewAll.Rows.Count > 0)
                    {
                        DialogResult DRDellPC = MessageBox.Show("Вы уверены, что хотите удалить тип работы?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (DRDellPC == DialogResult.Yes)
                        {
                            int indRow = dataGridViewAll.CurrentRow.Index;
                            int idTW = Convert.ToInt32(dataGridViewAll.Rows[indRow].Cells[0].Value);
                            sql = "DELETE FROM Work WHERE id_work= '" + idTW.ToString() + "'";
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            fillTableTypeWork();
                            MessageBox.Show("Тип работы успешно удален.",
                                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невыбран тип работы для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("В данный момент сервер находится в нерабочем состоянии.\r\nОбратитесь к системному администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 1049)
                {
                    MessageBox.Show("Отсутствует база данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Невозможно удалить тип работы так как он используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void добавитьВидРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddUpdWork formAddUpdWork = new FormAddUpdWork();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    if (formAddUpdWork.ShowDialog() == DialogResult.OK)
                    {
                        sql = "INSERT INTO Type_work (id_type_work, Name_work) " +
                            "VALUES (NULL, '" + formAddUpdWork.textBoxNameWork.Text + "')";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Вы успешно добавили новый вид работы.",
                            "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        fillTableVidWork();
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("В данный момент сервер находится в нерабочем состоянии.\r\nОбратитесь к системному администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 1049)
                {
                    MessageBox.Show("Отсутствует база данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void редактироватьВидРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddUpdWork formAddUpdWork = new FormAddUpdWork();
            formAddUpdWork.labelINFO.Text = "Редактировать данные о виде работы";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    if (dataGridViewAll.Rows.Count > 0)
                    {
                        int indRow = dataGridViewAll.CurrentRow.Index;
                        int idVW = Convert.ToInt32(dataGridViewAll.Rows[indRow].Cells[0].Value);
                        formAddUpdWork.textBoxNameWork.Text = dataGridViewAll.Rows[indRow].Cells[1].Value.ToString();

                        if (formAddUpdWork.ShowDialog() == DialogResult.OK)
                        {
                            sql = "UPDATE Type_work SET " +
                                "Name_work = '" + formAddUpdWork.textBoxNameWork.Text + "' WHERE id_type_work= '" + idVW + "'";
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            fillTableVidWork();
                            MessageBox.Show("Вы успешно отредактировали вид работы.",
                                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невыбран вид работы для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("В данный момент сервер находится в нерабочем состоянии.\r\nОбратитесь к системному администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 1049)
                {
                    MessageBox.Show("Отсутствует база данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void удалитьВидРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewAll.CurrentRow == null)
                { MessageBox.Show("Отсутвует список специальностей для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    if (dataGridViewAll.Rows.Count > 0)
                    {
                        DialogResult DRDellVidWork = MessageBox.Show("Вы уверены, что хотите удалить специальность?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (DRDellVidWork == DialogResult.Yes)
                        {
                            int indRow = dataGridViewAll.CurrentRow.Index;
                            int idVid = Convert.ToInt32(dataGridViewAll.Rows[indRow].Cells[0].Value);
                            sql = "DELETE FROM Type_work WHERE id_type_work= '" + idVid.ToString() + "'";
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            fillTableVidWork();
                            MessageBox.Show("Вид работы успешно удален.", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невыбран вид работы для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Вы не можете удалить этот вид работы, так как он используется.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void добавитьСпециальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddUpdSpecial formAddUpdSpecial = new FormAddUpdSpecial();
            if (formAddUpdSpecial.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(myConnString))
                    {
                        conn.Open();
                        sql = "INSERT INTO Specialization (id_specialization,Kod,Name,Qualification) " +
                            "VALUES (NULL,'" + formAddUpdSpecial.textBoxKod.Text +
                            "','" + formAddUpdSpecial.textBoxNameSpec.Text +
                            "','" + formAddUpdSpecial.textBoxQol.Text + "')";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Вы успешно добавили новую специальность: "
                            + formAddUpdSpecial.textBoxKod.Text + " " + formAddUpdSpecial.textBoxNameSpec.Text,
                            "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        fillTableSpec();
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1042)
                    {
                        MessageBox.Show("В данный момент сервер находится в нерабочем состоянии." +
                            "\r\nОбратитесь к системному администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (ex.Number == 1049)
                    {
                        MessageBox.Show("Отсутствует база данных!",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void редактироватьСпециальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddUpdSpecial formAddUpdSpecial = new FormAddUpdSpecial();
            formAddUpdSpecial.labelINFO.Text = "Редактировать данные о специальности";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    if (dataGridViewAll.Rows.Count > 0)
                    {
                        int indRow = dataGridViewAll.CurrentRow.Index;
                        int idS = Convert.ToInt32(dataGridViewAll.Rows[indRow].Cells[0].Value);
                        formAddUpdSpecial.textBoxKod.Text = dataGridViewAll.Rows[indRow].Cells[1].Value.ToString();
                        formAddUpdSpecial.textBoxNameSpec.Text = dataGridViewAll.Rows[indRow].Cells[2].Value.ToString();
                        formAddUpdSpecial.textBoxQol.Text = dataGridViewAll.Rows[indRow].Cells[3].Value.ToString();

                        if (formAddUpdSpecial.ShowDialog() == DialogResult.OK)
                        {
                            sql = "UPDATE Specialization SET " +
                               "Kod = '" + formAddUpdSpecial.textBoxKod.Text +
                               "', Name = '" + formAddUpdSpecial.textBoxNameSpec.Text +
                               "', Qualification = '" + formAddUpdSpecial.textBoxQol.Text +
                               "' WHERE id_specialization= '" + idS + "'";
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            fillTableSpec();
                            MessageBox.Show("Вы успешно отредактировали специальность.",
                                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невыбрана специальность для редактирования!",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("В данный момент сервер находится в нерабочем состоянии." +
                        "\r\nОбратитесь к системному администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 1049)
                {
                    MessageBox.Show("Отсутствует база данных!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void удалитьСпециальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewAll.CurrentRow == null)
            {
                MessageBox.Show("Отсутвует список специальностей для удаления",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
            }
            using (MySqlConnection conn = new MySqlConnection(myConnString))
            {
                conn.Open();
                try
                {
                    if (dataGridViewAll.Rows.Count > 0)
                    {
                        DialogResult DRDellSpec = MessageBox.Show("Вы уверены, что хотите удалить специальность?",
                            "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (DRDellSpec == DialogResult.Yes)
                        {
                            int indRow = dataGridViewAll.CurrentRow.Index;
                            int idSpec = Convert.ToInt32(dataGridViewAll.Rows[indRow].Cells[0].Value);
                            sql = "DELETE FROM Specialization WHERE id_specialization= '" + idSpec.ToString() + "'";
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            fillTableSpec();
                            MessageBox.Show("Специальность успешно удалена.",
                                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Невыбрана специальность для удаления!",
                            "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    if (ex.Number == 1042)
                    {
                        MessageBox.Show("В данный момент сервер находится в нерабочем состоянии." +
                            "\r\nОбратитесь к системному администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (ex.Number == 1049)
                    {
                        MessageBox.Show("Отсутствует база данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MessageBox.Show("Вы не можете удалить эту специальность, так как она еще используется.",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void добавитьРаботуСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddUpdWorkStud formAddUpdWorkStud = new FormAddUpdWorkStud();
            formAddUpdWorkStud.comboBoxTypeWork.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    sql = "SELECT Work.id_work, Work.Professional_module, Work.`Group`, Work.`Year`, Type_work.Name_work FROM Work " +
                        "JOIN Type_work ON Work.id_type_work = Type_work.id_type_work";
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    formAddUpdWorkStud.comboBoxTypeWork.Items.Clear();
                    while (reader.Read())
                    {
                        formAddUpdWorkStud.comboBoxTypeWork.Items.Add(reader["id_work"].ToString() + " | "
                            + reader["Name_work"].ToString() + " | " + reader["Professional_module"].ToString() + " | "
                            + reader["Group"].ToString() + " | " + reader["Year"].ToString());
                    }
                    reader.Close();

                    if (formAddUpdWorkStud.ShowDialog() == DialogResult.OK)
                    {
                        string input = formAddUpdWorkStud.comboBoxTypeWork.Text;
                        int separatorIndex = input.IndexOf('|');
                        string result = input.Substring(0, separatorIndex).Trim();

                        int idWork;
                        sql = "SELECT id_work FROM Work WHERE Name= '" + formAddUpdWorkStud.comboBoxTypeWork.Text + "'";
                        cmd = new MySqlCommand(sql, conn);
                        idWork = Convert.ToInt32(cmd.ExecuteScalar());

                        int idStud;
                        sql = "SELECT id_student FROM Student WHERE FIO= '" + formAddUpdWorkStud.textBoxFIOStud.Text + "'";
                        cmd = new MySqlCommand(sql, conn);
                        idStud = Convert.ToInt32(cmd.ExecuteScalar());

                        sql = "INSERT INTO work_stud (id_work_stud, Topic, id_student, id_work) " +
                            "VALUES (NULL, '" + formAddUpdWorkStud.textBoxTopic.Text +
                            "','" + idStud + "','" + idWork + "')";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Вы успешно добавили работу студента",
                            "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        fillTableWorkStud();
                    }
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("В данный момент сервер находится в нерабочем состоянии.\r\nОбратитесь к системному администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 1049)
                {
                    MessageBox.Show("Отсутствует база данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void редактироватьРаботуСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddUpdWorkStud formAddUpdWorkStud = new FormAddUpdWorkStud();
            formAddUpdWorkStud.labelINFO.Text = "Редактировать даннын о работе студента";
            formAddUpdWorkStud.comboBoxTypeWork.DropDownStyle = ComboBoxStyle.DropDown;
            try
            {
                if (dataGridViewAll.Rows.Count > 0)
                {
                    using (MySqlConnection conn = new MySqlConnection(myConnString))
                    {
                        conn.Open();
                        int indRow = dataGridViewAll.CurrentRow.Index;
                        int idWS = Convert.ToInt32(dataGridViewAll.Rows[indRow].Cells[0].Value);
                        formAddUpdWorkStud.textBoxTopic.Text = dataGridViewAll.Rows[indRow].Cells[1].Value.ToString();
                        formAddUpdWorkStud.textBoxFIOStud.Text = dataGridViewAll.Rows[indRow].Cells[2].Value.ToString();

                        sql = "SELECT id_work FROM Work";
                        cmd = new MySqlCommand(sql, conn);
                        formAddUpdWorkStud.comboBoxTypeWork.Text = Convert.ToString(cmd.ExecuteScalar()) + " | "
                            + dataGridViewAll.Rows[indRow].Cells[3].Value.ToString() + " | " + dataGridViewAll.Rows[indRow].Cells[4].Value.ToString() +
                            " | " + dataGridViewAll.Rows[indRow].Cells[5].Value.ToString() + " | " + dataGridViewAll.Rows[indRow].Cells[6].Value.ToString();

                        sql = "SELECT Work.id_work, Work.Professional_module, Work.`Group`, Work.`Year`, Type_work.Name_work FROM Work " +
                            "JOIN Type_work ON Work.id_type_work = Type_work.id_type_work";
                        cmd = new MySqlCommand(sql, conn);
                        MySqlDataReader reader;
                        reader = cmd.ExecuteReader();
                        formAddUpdWorkStud.comboBoxTypeWork.Items.Clear();
                        while (reader.Read())
                        {
                            formAddUpdWorkStud.comboBoxTypeWork.Items.Add(reader["id_work"].ToString() + " | "
                                + reader["Name_work"].ToString() + " | " + reader["Professional_module"].ToString() + " | "
                                + reader["Group"].ToString() + " | " + reader["Year"].ToString());
                        }
                        reader.Close();

                        if (formAddUpdWorkStud.ShowDialog() == DialogResult.OK)
                        {
                            string input = formAddUpdWorkStud.comboBoxTypeWork.Text;
                            int separatorIndex = input.IndexOf('|');
                            string result = input.Substring(0, separatorIndex).Trim();

                            int idStud;
                            sql = "SELECT id_student FROM Student WHERE FIO= '" + formAddUpdWorkStud.textBoxFIOStud.Text + "'";
                            cmd = new MySqlCommand(sql, conn);
                            idStud = Convert.ToInt32(cmd.ExecuteScalar());

                            sql = "UPDATE work_stud SET " +
                                  "Topic = '" + formAddUpdWorkStud.textBoxTopic.Text +
                                  "', id_student = " + idStud +
                                  ", id_work = " + result +
                                  " WHERE id_work_stud = " + idWS;
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                            fillTableWorkStud();
                            MessageBox.Show("Вы успешно отредактировали работу студента",
                                "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Невыбрана работа студента для редактирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("В данный момент сервер находится в нерабочем состоянии.\r\nОбратитесь к системному администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 1049)
                {
                    MessageBox.Show("Отсутствует база данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void удалитьРаботуСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewAll.Rows.Count > 0)
                {
                    if (dataGridViewAll.CurrentRow == null)
                    {
                        MessageBox.Show("Отсутвует список работ студентов для удаления",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                    }
                    using (MySqlConnection conn = new MySqlConnection(myConnString))
                    {
                        conn.Open();
                        int indRow = dataGridViewAll.CurrentRow.Index;
                        int id = Convert.ToInt32(dataGridViewAll.Rows[indRow].Cells[0].Value);
                        sql = @"DROP PROCEDURE IF EXISTS `destroy_student_work`;
                            CREATE PROCEDURE  `destroy_student_work`( 
                            IN `p_id_work_stud` INT)
                            BEGIN 
                                DECLARE v_rows_affected INT DEFAULT 0;
                                START TRANSACTION;
                                INSERT INTO Destruction_of_documents(
                                    Prichina_Unich, Date_unich, Vid_documentd, FIO,
                                    God_nach_obuch, God_ocon, `Group`, Namber_personal_del, Kolichestvo_list,
                                    Form_obuch, God_nach_LD, God_ocon_LD, Kod, Name_spec, Qualification,
                                    Professional_module, Topic, Name_work, Expelled)
                                SELECT 'Истечение срока хранения', DATE_FORMAT(NOW(), '%d.%m.%Y'), 
                                    'Работа студента', s.FIO, s.God_nach_ob, s.God_ocon, s.`Group`, '', '', 
                                    '', '', '', '', '', '', w.Professional_module, ws.Topic, tw.Name_work, 'Нет'
                                FROM Work_Stud ws
                                JOIN Student s ON ws.id_student = s.id_student
                                JOIN Personal_case pc ON s.id_student = pc.id_student
                                JOIN Work w ON ws.id_work = w.id_work
                                JOIN Type_work tw ON w.id_type_work = tw.id_type_work
                                WHERE ws.id_work_stud = p_id_work_stud;
                                SET v_rows_affected = ROW_COUNT();
                                DELETE FROM Work_Stud WHERE id_work_stud = p_id_work_stud;
                                SET v_rows_affected = v_rows_affected + ROW_COUNT();
                                COMMIT;
                            END;";

                        cmd = new MySqlCommand(sql, conn);
                        cmd.ExecuteNonQuery();
                        string callProc = "CALL archive_fund.destroy_student_work(@id)";
                        MySqlCommand callCmd = new MySqlCommand(callProc, conn);
                        callCmd.Parameters.AddWithValue("@id", id);
                        callCmd.ExecuteNonQuery();
                        fillTableWorkStud();
                        MessageBox.Show("Вы успешно удалили работу студента, её данные сохранены в \"Удаленные документы\"",
                            "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Невыбрана работа студента для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1042)
                {
                    MessageBox.Show("В данный момент сервер находится в нерабочем состоянии.\r\nОбратитесь к системному администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (ex.Number == 1049)
                {
                    MessageBox.Show("Отсутствует база данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBoxImport_Click(object sender, EventArgs e)
        {
            if (dataGridViewAll.Rows.Count > 0)
            {
                if (labelText.Text == "Личные дела студентов")
                {
                    DataTable dataTable = GetDataFormDatabase("SELECT Personal_Case.Number_personal_del," +
                        "(SELECT FIO FROM Student WHERE id_student = Personal_Case.id_student) AS FIO_Stud," +
                        "(SELECT Name FROM Specialization WHERE id_specialization = Personal_Case.id_specialization) AS Spesial " +
                        "FROM Personal_Case ");

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.FileName = "Расположение личных дел в архиве " + DateTime.Now.ToString("d");
                    saveFileDialog.Filter = "PDF fiter (*.pdf)|*.pdf";
                    List<int> id = new List<int>();
                    for (int i = 0; i < dataGridViewAll.Rows.Count; i++)
                    {
                        id.Add(Convert.ToInt32(dataGridViewAll.Rows[i].Cells[0].Value.ToString().Trim()));
                    }
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ExportToPDFLD(dataTable, saveFileDialog.FileName, id);
                    }
                    MessageBox.Show("Отчет по личным делам студентов успешно сохранен!",
                        "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataTable dataTableWork = GetDataFormDatabaseWork("SELECT Topic, Student.FIO, Work.Group, Work.Year, Work.Number_setl, Work.Number_pol " +
                        "FROM Student INNER JOIN Work_Stud ON Student.id_student = Work_Stud.id_student " +
                        "INNER JOIN Work ON Work_Stud.id_work = Work.id_work");

                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.FileName = "Расположение работ студентов " + DateTime.Now.ToString("d");
                    saveFileDialog.Filter = "PDF fiter (*.pdf)|*.pdf";
                    List<int> id = new List<int>();
                    for (int i = 0; i < dataGridViewAll.Rows.Count; i++)
                    {
                        id.Add(Convert.ToInt32(dataGridViewAll.Rows[i].Cells[0].Value.ToString().Trim()));
                    }
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        ExportToPDFWork(dataTableWork, saveFileDialog.FileName, id);
                    }
                    MessageBox.Show("Отчет по работам студентов успешно сохранен!",
                        "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Отсутствуют данные для импорта!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Дата и время: " + DateTime.Now.ToString();
        }

        private void buttonCloseSession_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAuthorization formAuthorization = new FormAuthorization();
            formAuthorization.ShowDialog();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            FormFAQ formFAQ = new FormFAQ();
            formFAQ.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (labelText.Text == "Личные дела студентов")
            {
                splitContainer1.Panel2Collapsed = true;
                fillTablePersCaseSort();
            }
            if (labelText.Text == "Список работ студентов")
            {
                splitContainer1.Panel2Collapsed = true;
                fillTableWorkStudSearchT();
            }
            if (labelText.Text == "Список утелизированных документов с истекшим сроком хранения")
            {
                splitContainer1.Panel2Collapsed = true;
                fillTableDestDocsSearch();
            }
            if (labelText.Text == "Список студентов техникума")
            {
                splitContainer1.Panel2Collapsed = true;
                fillTableStudSearch();
            }
        }

        private void checkBoxLD_CheckedChanged(object sender, EventArgs e)
        {
            fillTableWorkStudSortW();
        }

        private void checkBoxWorkStud_CheckedChanged(object sender, EventArgs e)
        {
            fillTableWorkStudSortW();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = false;
        }

        private void checkBoxSroc_CheckedChanged(object sender, EventArgs e)
        {
            if (labelText.Text == "Личные дела студентов")
            {
                if (checkBoxSroc.Checked == true) { fillTablePersCaseSroc(); } else { fillTablePersCase(); }
            }
            if (labelText.Text == "Список работ студентов")
            {
                if (checkBoxSroc.Checked == true) { fillTableWorkStudSroc(); } else { fillTableWorkStud(); }
            }
        }

        private void toolStripDropDownButtonHelp_Click(object sender, EventArgs e)
        {
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string helpFilePath = Path.Combine(appDirectory, "Reference", "Help.chm");
            Process.Start(new ProcessStartInfo(helpFilePath)
            {
                UseShellExecute = true
            });
        }

        private void FormDescktop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}