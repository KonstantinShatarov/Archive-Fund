using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static Castle.MicroKernel.ModelBuilder.Descriptors.InterceptorDescriptor;

namespace Архивный_фонд
{
    internal class ClassListSort
    {
        MySqlCommand cmd;
        string line;
        string myConnString = "";
        string sql;
        public string Surname, NameS, Part, role, Post;

        public void connect()
        {
            // Считывание данных из файла config.ini и присваевание данных переменной myConnString
            StreamReader Fileini = new StreamReader("config.ini");
            while ((line = Fileini.ReadLine()) != null)
            {
                myConnString += line + ";";
            }
            Fileini.Close();
        }

        public struct TableDestDocSearch
        {
            public string id, Prichina, Date, FIO_stud, God_N_ob, God_O_ob, Group, Num_LD, Kol_list, Forma_ob, 
                God_N_LD, God_O_LD, KodSP, Name_SP, Qualif, Prof_Mod, Topic, Name_Work, Vid_Doc;
        }
        public List<TableDestDocSearch> getTableDestDocsSearch(string Topic , string group, string FIO)
        {
            List<TableDestDocSearch> tableDestDocs = new List<TableDestDocSearch>();
            {
                TableDestDocSearch tabDestDoc;
                tableDestDocs.Clear();
                connect();
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    sql = "SELECT * FROM Destruction_of_documents";
                    if (!string.IsNullOrEmpty(Topic))
                    { sql += $" WHERE Topic LIKE '%{Topic}%'"; }
                    if (!string.IsNullOrEmpty(group))
                    { sql += $" WHERE `Group` LIKE '%{group}%'"; }
                    if (!string.IsNullOrEmpty(FIO))
                    { sql += $" WHERE FIO LIKE '%{FIO}%'"; }
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tabDestDoc.id = reader["id_AKT_ynicht"].ToString();
                        tabDestDoc.Prichina = reader["Prichina_Unich"].ToString();
                        tabDestDoc.Date = reader["Date_unich"].ToString();
                        tabDestDoc.FIO_stud = reader["FIO"].ToString();
                        tabDestDoc.God_N_ob = reader["God_nach_obuch"].ToString();
                        tabDestDoc.God_O_ob = reader["God_ocon"].ToString();
                        tabDestDoc.Group = reader["Group"].ToString();
                        tabDestDoc.Num_LD = reader["Namber_personal_del"].ToString();
                        tabDestDoc.Kol_list = reader["Kolichestvo_list"].ToString();
                        tabDestDoc.Forma_ob = reader["Form_obuch"].ToString();
                        tabDestDoc.God_N_LD = reader["God_nach_LD"].ToString();
                        tabDestDoc.God_O_LD = reader["God_ocon_LD"].ToString();
                        tabDestDoc.KodSP = reader["Kod"].ToString();
                        tabDestDoc.Name_SP = reader["Name_spec"].ToString();
                        tabDestDoc.Qualif = reader["Qualification"].ToString();
                        tabDestDoc.Prof_Mod = reader["Professional_module"].ToString();
                        tabDestDoc.Topic = reader["Topic"].ToString();
                        tabDestDoc.Name_Work = reader["Name_work"].ToString();
                        tabDestDoc.Vid_Doc = reader["Vid_documentd"].ToString();
                        tableDestDocs.Add(tabDestDoc);
                    }
                    reader.Close();
                }
            }
            return tableDestDocs;
        }

        public struct TableWorkStudSearchT
        {
            public string id, Topic, FIO_stud, Name_work, Prof_modul, Group, Year, Num_stel, Num_pol;
        }
        public List<TableWorkStudSearchT> getTableWorkStudSearchT(string Topic, string group, string FIO)
        {
            List<TableWorkStudSearchT> tableWorkStud = new List<TableWorkStudSearchT>();
            {
                TableWorkStudSearchT tabWorkStud;
                tableWorkStud.Clear();
                connect();
                FormDescktop formDescktop = new FormDescktop();
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    sql = "SELECT work_stud.id_work_stud, work_stud.Topic, Student.FIO AS FIO_Stud, Type_work.Name_work AS Name_work, " +
                    "Work.Professional_module AS Prof_modul, Work.Group, Work.Year, Work.Number_setl, Work.Number_pol " +
                    "FROM work_stud JOIN Student ON work_stud.id_student = Student.id_student " +
                    "JOIN Work ON work_stud.id_work = Work.id_work JOIN Type_work ON Work.id_type_work = Type_work.id_type_work ";
                    if (!string.IsNullOrEmpty(Topic))
                    {
                        sql += $" WHERE work_stud.Topic LIKE '%{Topic}%'";
                    }
                    if (!string.IsNullOrEmpty(group))
                    {
                        sql += $" WHERE (SELECT `Group` FROM Student WHERE id_student = work_stud.id_student) LIKE '%{group}%'";
                    }
                    if (!string.IsNullOrEmpty(FIO))
                    {
                        sql += $" WHERE (SELECT FIO FROM Student WHERE id_student = work_stud.id_student) LIKE '%{FIO}%'";
                    }
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tabWorkStud.id = reader["id_work_stud"].ToString();
                        tabWorkStud.Topic = reader["Topic"].ToString();
                        tabWorkStud.FIO_stud = reader["FIO_Stud"].ToString();
                        tabWorkStud.Name_work = reader["Name_work"].ToString();
                        tabWorkStud.Prof_modul = reader["Prof_modul"].ToString();
                        tabWorkStud.Group = reader["Group"].ToString();
                        tabWorkStud.Year = reader["Year"].ToString();
                        tabWorkStud.Num_stel = reader["Number_setl"].ToString();
                        tabWorkStud.Num_pol = reader["Number_pol"].ToString();
                        tableWorkStud.Add(tabWorkStud);
                    }
                    reader.Close();
                }
            }
            return tableWorkStud;
        }

        public struct TablePersCaseSroc
        {
            public string id, Num_case, Kol_list, Form_ob, Groups, Srock_Hran, Num_sh, Num_pol, Otchis, FIO_Stud, God_N_ob, God_O_ob, God_N_LD, God_O_LD, Spesial;
        }
        public List<TablePersCaseSroc> getTablePersCaseSroc()
        {
            List<TablePersCaseSroc> tablePersCases = new List<TablePersCaseSroc>();
            {
                TablePersCaseSroc tabPersCaseSroc;
                tablePersCases.Clear();
                connect();
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();

                    sql = "SELECT Personal_case.*," +
                          "(SELECT FIO FROM Student WHERE id_student = Personal_case.id_student) AS FIO_Stud," +
                          "(SELECT `Group` FROM Student WHERE id_student = Personal_case.id_student) AS `Groups`," +
                          "(SELECT Name FROM Specialization WHERE id_specialization = Personal_case.id_specialization) AS Spesial " +
                          "FROM Personal_case WHERE God_ocon_LD = YEAR(CURDATE());";
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tabPersCaseSroc.id = reader["id_personal_delo"].ToString();
                        tabPersCaseSroc.Num_case = reader["Number_personal_del"].ToString();
                        tabPersCaseSroc.Kol_list = reader["Kolichestvo_list"].ToString();
                        tabPersCaseSroc.Form_ob = reader["form_obuch"].ToString();
                        tabPersCaseSroc.Srock_Hran = reader["Srock_Hraneniya"].ToString();
                        tabPersCaseSroc.Num_sh = reader["Number_Shelf"].ToString();
                        tabPersCaseSroc.Num_pol = reader["Number_polki"].ToString();
                        tabPersCaseSroc.Otchis = reader["Expelled"].ToString();
                        tabPersCaseSroc.FIO_Stud = reader["FIO_Stud"].ToString();
                        tabPersCaseSroc.Groups = reader["Groups"].ToString();
                        tabPersCaseSroc.God_N_ob = reader["God_Nach_LD"].ToString();
                        tabPersCaseSroc.God_O_ob = reader["God_ocon_LD"].ToString();
                        tabPersCaseSroc.God_N_LD = reader["God_nach_obuch"].ToString();
                        tabPersCaseSroc.God_O_LD = reader["God_ocon_obuch"].ToString();
                        tabPersCaseSroc.Spesial = reader["Spesial"].ToString();
                        tablePersCases.Add(tabPersCaseSroc);
                    }
                    reader.Close();
                }
            }
            return tablePersCases;
        }

        public struct TablePersCaseSort
        {
            public string id, Num_case, Kol_list, Form_ob, Groups, Srock_Hran, Num_sh, Num_pol, Otchis, FIO_Stud, God_N_ob, God_O_ob, God_N_LD, God_O_LD, Spesial;
        }
        public List<TablePersCaseSort> getTablePersCaseSort(string group, string FIO)
        {
            List<TablePersCaseSort> tablePersCasesSort = new List<TablePersCaseSort>();
            TablePersCaseSort tabPersCaseSort;
            tablePersCasesSort.Clear();
            connect();
            FormDescktop formDescktop = new FormDescktop();
            using (MySqlConnection conn = new MySqlConnection(myConnString))
            {
                conn.Open();
                sql = "SELECT Personal_case.*," +
                      "(SELECT FIO FROM Student WHERE id_student = Personal_case.id_student) AS FIO_Stud," +
                      "(SELECT `Group` FROM Student WHERE id_student = Personal_case.id_student) AS `Groups`," +
                      "(SELECT Name FROM Specialization WHERE id_specialization = Personal_case.id_specialization) AS Spesial " +
                      "FROM Personal_case";
                if (!string.IsNullOrEmpty(group))
                {
                    sql += $" WHERE (SELECT `Group` FROM Student WHERE id_student = Personal_case.id_student) LIKE '%{group}%'";
                }
                if (!string.IsNullOrEmpty(FIO))
                {
                    sql += $" WHERE (SELECT FIO FROM Student WHERE id_student = Personal_case.id_student) LIKE '%{FIO}%'";
                }
                cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tabPersCaseSort.id = reader["id_personal_delo"].ToString();
                    tabPersCaseSort.Num_case = reader["Number_personal_del"].ToString();
                    tabPersCaseSort.Kol_list = reader["Kolichestvo_list"].ToString();
                    tabPersCaseSort.Form_ob = reader["form_obuch"].ToString();
                    tabPersCaseSort.Srock_Hran = reader["Srock_Hraneniya"].ToString();
                    tabPersCaseSort.Num_sh = reader["Number_Shelf"].ToString();
                    tabPersCaseSort.Num_pol = reader["Number_polki"].ToString();
                    tabPersCaseSort.Otchis = reader["Expelled"].ToString();
                    tabPersCaseSort.FIO_Stud = reader["FIO_Stud"].ToString();
                    tabPersCaseSort.Groups = reader["Groups"].ToString();
                    tabPersCaseSort.God_N_ob = reader["God_Nach_LD"].ToString();
                    tabPersCaseSort.God_O_ob = reader["God_ocon_LD"].ToString();
                    tabPersCaseSort.God_N_LD = reader["God_nach_obuch"].ToString();
                    tabPersCaseSort.God_O_LD = reader["God_ocon_obuch"].ToString();
                    tabPersCaseSort.Spesial = reader["Spesial"].ToString();
                    tablePersCasesSort.Add(tabPersCaseSort);
                }
                reader.Close();
            }
            return tablePersCasesSort;
        }

        public struct TableDestDocSort
        {
            public string id, Prichina, Date, FIO_stud, God_N_ob, God_O_ob, Group, Num_LD, Kol_list, Forma_ob, God_N_LD, God_O_LD, KodSP, Name_SP, Qualif, Prof_Mod, Topic, Name_Work, Vid_Doc;
        }
        public List<TableDestDocSort> getTableDestDocsSort( bool a,bool b)
        {
            List<TableDestDocSort> tabDestDocSearch = new List<TableDestDocSort>();
            {
                TableDestDocSort tabDestDocS;
                tabDestDocSearch.Clear();
                connect();
                FormDescktop formDescktop = new FormDescktop();
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    string search = "";
                    if (b == true && a == false)
                    {
                        search = "Личное дело";
                    }
                    else if (a == true && b == false)
                    {
                        search = "Работа студента";
                    }
                    sql = "SELECT * FROM Destruction_of_documents";
                    if (!string.IsNullOrEmpty(search))
                    {
                        sql += " WHERE Vid_documentd LIKE '%" + search + "%'";
                    }
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tabDestDocS.id = reader["id_AKT_ynicht"].ToString();
                        tabDestDocS.Prichina = reader["Prichina_Unich"].ToString();
                        tabDestDocS.Date = reader["Date_unich"].ToString();
                        tabDestDocS.FIO_stud = reader["FIO"].ToString();
                        tabDestDocS.God_N_ob = reader["God_nach_obuch"].ToString();
                        tabDestDocS.God_O_ob = reader["God_ocon"].ToString();
                        tabDestDocS.Group = reader["Group"].ToString();
                        tabDestDocS.Num_LD = reader["Namber_personal_del"].ToString();
                        tabDestDocS.Kol_list = reader["Kolichestvo_list"].ToString();
                        tabDestDocS.Forma_ob = reader["Form_obuch"].ToString();
                        tabDestDocS.God_N_LD = reader["God_nach_LD"].ToString();
                        tabDestDocS.God_O_LD = reader["God_ocon_LD"].ToString();
                        tabDestDocS.KodSP = reader["Kod"].ToString();
                        tabDestDocS.Name_SP = reader["Name_spec"].ToString();
                        tabDestDocS.Qualif = reader["Qualification"].ToString();
                        tabDestDocS.Prof_Mod = reader["Professional_module"].ToString();
                        tabDestDocS.Topic = reader["Topic"].ToString();
                        tabDestDocS.Name_Work = reader["Name_work"].ToString();
                        tabDestDocS.Vid_Doc = reader["Vid_documentd"].ToString();
                        tabDestDocSearch.Add(tabDestDocS);
                    }
                    reader.Close();
                }
            }
            return tabDestDocSearch;
        }

        public struct TableWorkStudSroc
        {
            public string id, Topic, FIO_stud, Name_work, Prof_modul, Group, Year, Num_stel, Num_pol;
        }
        public List<TableWorkStudSroc> getTableWorkStudSroc()
        {
            List<TableWorkStudSroc> tableWorkStud = new List<TableWorkStudSroc>();
            {
                TableWorkStudSroc tabWorkStud;
                tableWorkStud.Clear();
                connect();
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    sql = "SELECT work_stud.id_work_stud, work_stud.Topic, Student.FIO AS FIO_Stud, " +
                        "Type_work.Name_work AS Name_work, Work.Professional_module AS Prof_modul, Work.Group, Work.Year, " +
                        "Work.Number_setl, Work.Number_pol FROM work_stud " +
                        "JOIN Student ON work_stud.id_student = Student.id_student " +
                        "JOIN Work ON work_stud.id_work = Work.id_work " +
                        "JOIN Type_work ON Work.id_type_work = Type_work.id_type_work " +
                        "WHERE YEAR(CURDATE()) - CAST(Work.Year AS UNSIGNED) >= 5;";
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tabWorkStud.id = reader["id_work_stud"].ToString();
                        tabWorkStud.Topic = reader["Topic"].ToString();
                        tabWorkStud.FIO_stud = reader["FIO_Stud"].ToString();
                        tabWorkStud.Name_work = reader["Name_work"].ToString();
                        tabWorkStud.Prof_modul = reader["Prof_modul"].ToString();
                        tabWorkStud.Group = reader["Group"].ToString();
                        tabWorkStud.Year = reader["Year"].ToString();
                        tabWorkStud.Num_stel = reader["Number_setl"].ToString();
                        tabWorkStud.Num_pol = reader["Number_pol"].ToString();
                        tableWorkStud.Add(tabWorkStud);
                    }
                    reader.Close();
                }
            }
            return tableWorkStud;
        }

        public struct TableStudSearch
        {
            public string id, FIO, God_nach_ob, Group;
        }
        public List<TableStudSearch> getTableStudSearch(string group, string FIO)
        {
            List<TableStudSearch> tableStuds = new List<TableStudSearch>();
            {
                TableStudSearch tabStud;
                tableStuds.Clear();
                connect();
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();

                    sql = "SELECT id_student,FIO,God_nach_ob,`Group` FROM Student";
                    if (!string.IsNullOrEmpty(group))
                    {
                        sql += $" WHERE `Group` LIKE '%{group}%'";
                    }
                    if (!string.IsNullOrEmpty(FIO))
                    {
                        sql += $" WHERE FIO LIKE '%{FIO}%'";
                    }
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tabStud.id = reader["id_student"].ToString();
                        tabStud.FIO = reader["FIO"].ToString();
                        tabStud.God_nach_ob = reader["God_nach_ob"].ToString();
                        tabStud.Group = reader["Group"].ToString();
                        tableStuds.Add(tabStud);
                    }
                    reader.Close();
                }
            }
            return tableStuds;
        }
    }
}
