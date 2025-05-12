using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Архивный_фонд
{
    internal class ClassListsData
    {
        MySqlCommand cmd;
        string line;
        string myConnString = "";
        string sql;
        public string Surname, NameS, Part, role, Post;
        FormDescktop formDescktop = new FormDescktop();
        public struct TableUsers
        {
            public string id_user, Login, Rol, Surname, Name, Patronymic, Post, Status;
        }

        public List<TableUsers> getTable()
        {
            List<TableUsers> tableUsers = new List<TableUsers>();
            {
                TableUsers tabUser;
                tableUsers.Clear();
                connect();
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    sql = "SELECT * FROM user";
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tabUser.id_user = reader["id_user"].ToString();
                        tabUser.Login = reader["Login"].ToString();
                        tabUser.Rol = reader["Rol"].ToString();
                        tabUser.Surname = reader["Surname"].ToString();
                        tabUser.Name = reader["Name"].ToString();
                        tabUser.Patronymic = reader["Patronymic"].ToString();
                        tabUser.Post = reader["Post"].ToString();
                        tabUser.Status = reader["Status"].ToString();
                        tableUsers.Add(tabUser);
                    }
                    reader.Close();
                }
            }
            return tableUsers;
        }


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
        public struct TableSpesial
        {
            public string id, Kod, Name, Qualification;
        }

        public List<TableSpesial> getTableSpec()
        {
            List<TableSpesial> specials = new List<TableSpesial>();
            TableSpesial tabSpec;
            specials.Clear();
            connect();
            using (MySqlConnection conn = new MySqlConnection(myConnString))
            {
                conn.Open();
                sql = "SELECT * FROM Specialization";
                cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tabSpec.id = reader["id_specialization"].ToString();
                    tabSpec.Kod = reader["Kod"].ToString();
                    tabSpec.Name = reader["Name"].ToString();
                    tabSpec.Qualification = reader["Qualification"].ToString();
                    specials.Add(tabSpec);
                }
                reader.Close();
            }
            return specials;
        }

        public struct TableStud
        {
            public string id, FIO, God_nach_ob, Group;
        }

        public List<TableStud> getTableStud()
        {
            List<TableStud> tableStuds = new List<TableStud>();
            {
                TableStud tabStud;
                tableStuds.Clear();
                connect();
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    sql = "SELECT id_student,FIO,God_nach_ob,`Group` FROM Student";
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

        public struct TableVidWork
        {
            public string id, Name_work;
        }

        public List<TableVidWork> getTableVidWork()
        {
            List<TableVidWork> tableTypeWorks = new List<TableVidWork>();
            {
                TableVidWork tabTypeWork;
                tableTypeWorks.Clear();
                connect();
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    sql = "SELECT * FROM Type_work";
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tabTypeWork.id = reader["id_type_work"].ToString();
                        tabTypeWork.Name_work = reader["Name_work"].ToString();
                        tableTypeWorks.Add(tabTypeWork);
                    }
                    reader.Close();
                }
            }
            return tableTypeWorks;
        }

        public struct TableWorkStud
        {
            public string id, Topic, FIO_stud, Name_work, Prof_modul, Group, Year, Num_stel, Num_pol;
        }

        public List<TableWorkStud> getTableWorkStud()
        {
            List<TableWorkStud> tableWorkStud = new List<TableWorkStud>();
            {
                TableWorkStud tabWorkStud;
                tableWorkStud.Clear();
                connect();
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    sql = "SELECT work_stud.id_work_stud, work_stud.Topic, Student.FIO AS FIO_Stud, Type_work.Name_work AS Name_work, " +
                    "Work.Professional_module AS Prof_modul, Work.Group, Work.Year, Work.Number_setl, Work.Number_pol " +
                    "FROM work_stud JOIN Student ON work_stud.id_student = Student.id_student " +
                    "JOIN Work ON work_stud.id_work = Work.id_work JOIN Type_work ON Work.id_type_work = Type_work.id_type_work";
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

        public struct TablePersCase
        {
            public string id, Num_case, Kol_list, Form_ob,Groups, Srock_Hran, Num_sh, Num_pol, Otchis, FIO_Stud, God_N_ob, God_O_ob, God_N_LD, God_O_LD, Spesial;
        }

        public List <TablePersCase> getTablePersCase()
        {
            List<TablePersCase> tablePersCases = new List<TablePersCase>();
            {
                TablePersCase tabPersCase;
                tablePersCases.Clear();
                connect();
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    sql = "SELECT Personal_case.*," +
                          "(SELECT FIO FROM Student WHERE id_student = Personal_case.id_student) AS FIO_Stud," +
                          "(SELECT `Group` FROM Student WHERE id_student = Personal_case.id_student) AS `Groups`," +
                          "(SELECT Name FROM Specialization WHERE id_specialization = Personal_case.id_specialization) AS Spesial " +
                          "FROM Personal_case;";
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tabPersCase.id = reader["id_personal_delo"].ToString();
                        tabPersCase.Num_case = reader["Number_personal_del"].ToString();
                        tabPersCase.Kol_list = reader["Kolichestvo_list"].ToString();
                        tabPersCase.Form_ob = reader["form_obuch"].ToString();
                        tabPersCase.Srock_Hran = reader["Srock_Hraneniya"].ToString();
                        tabPersCase.Num_sh = reader["Number_Shelf"].ToString();
                        tabPersCase.Num_pol = reader["Number_polki"].ToString();
                        tabPersCase.Otchis = reader["Expelled"].ToString();
                        tabPersCase.FIO_Stud = reader["FIO_Stud"].ToString();
                        tabPersCase.Groups = reader["Groups"].ToString();
                        tabPersCase.God_N_ob = reader["God_Nach_LD"].ToString();
                        tabPersCase.God_O_ob = reader["God_ocon_LD"].ToString();
                        tabPersCase.God_N_LD = reader["God_nach_obuch"].ToString();
                        tabPersCase.God_O_LD = reader["God_ocon_obuch"].ToString();
                        tabPersCase.Spesial = reader["Spesial"].ToString();
                        tablePersCases.Add(tabPersCase);
                    }
                    reader.Close();
                }
            }
            return tablePersCases;
        }

        public struct TableDestDoc
        {
            public string id, Prichina,Date,FIO_stud,God_N_ob,God_O_ob,Group,Num_LD,Kol_list,Forma_ob,God_N_LD,God_O_LD,KodSP,Name_SP,Qualif,Prof_Mod,Topic,Name_Work,Vid_Doc;
        }

        public List<TableDestDoc> getTableDestDocs()
        {
            List<TableDestDoc> tableDestDocs = new List<TableDestDoc>();
            {
                TableDestDoc tabDestDoc;
                tableDestDocs.Clear();
                connect();
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    sql = "SELECT * FROM Destruction_of_documents";
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

        public struct TableTypeWork
        {
            public string id, NameWork, NumStel, NumPol, Prof_mod, Group, Yesr;
        }

        public List<TableTypeWork> getTableTypeWorks()
        {
            List<TableTypeWork> tableTypeWorks = new List<TableTypeWork>();
            {
                TableTypeWork tabTypeWork;
                tableTypeWorks.Clear();
                connect();
                using (MySqlConnection conn = new MySqlConnection(myConnString))
                {
                    conn.Open();
                    sql = "SELECT Work.id_work, Type_work.Name_work AS NameWork, " +
                     "Work.Number_pol AS NumPol, Work.Number_setl AS NumStel, " +
                     "Work.Group, Work.Professional_module AS Prof_mod, " +
                     "Work.Year " +
                     "FROM Work JOIN Type_work ON Work.id_type_work = Type_work.id_type_work";
                    cmd = new MySqlCommand(sql, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tabTypeWork.id = reader["id_work"].ToString();
                        tabTypeWork.NameWork = reader["NameWork"].ToString();
                        tabTypeWork.NumPol = reader["NumPol"].ToString();
                        tabTypeWork.NumStel = reader["NumStel"].ToString();
                        tabTypeWork.Group = reader["Group"].ToString();
                        tabTypeWork.Prof_mod = reader["Prof_mod"].ToString();
                        tabTypeWork.Yesr = reader["Year"].ToString();
                        tableTypeWorks.Add(tabTypeWork);
                    }
                    reader.Close();
                }
            }
            return tableTypeWorks;
        }       
    }
}