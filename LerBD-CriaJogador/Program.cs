using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace ReadData
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogadores jogadores = new Jogadores();

            using (var conn = new System.Data.SQLite.SQLiteConnection("Data Source=db_test_new.db;"))
            {
                conn.Open();

                using (var comm = new System.Data.SQLite.SQLiteCommand(conn))
                {
                    comm.CommandText = "SELECT * FROM Jogadores";

                    //Console.WriteLine("DataReader:");
                    //using (var reader = comm.ExecuteReader())
                    //{
                    //    while (reader.Read())
                    //    {
                    //        Console.WriteLine("Nome do Jogador: {0}", reader["index"]);
                    //    }
                    //}

                    Console.WriteLine("DataAdapter:");
                    var adapter = new System.Data.SQLite.SQLiteDataAdapter(comm);
                    var dataTable = new System.Data.DataTable();
                    adapter.Fill(dataTable);
                    foreach (System.Data.DataRow row in dataTable.Rows)
                    {
                        jogadores.Index = 0;
                        jogadores.Id = "";
                        jogadores.Position = "";
                        jogadores.Finishing = 0;
                        jogadores.HeadingAccuracy = 0;
                        jogadores.ShortPassing = 0;
                        jogadores.Dribbling = 0;
                        jogadores.FkAccuracy = 0;
                        jogadores.LongPassing = 0;
                        jogadores.Acceleration = 0;
                        jogadores.Reactions = 0;
                        jogadores.Stamina = 0;
                        jogadores.LongShots = 0;
                        jogadores.Marking = 0;
                        jogadores.Penalties = 0;
                        Console.WriteLine("ID do Jogador: {0}", row["index"]);
                        // Console.WriteLine($"Posicao do Jogador: {row["position"]}");
                    }
                }
            }
        }
    }

    class Jogadores
    {
        private long index;
        private string id;
        private string position;
        private float finishing;
        private float headingAccuracy;
        private float shortPassing;
        private float dribbling;
        private float fkAccuracy;
        private float longPassing;
        private float acceleration;
        private float reactions;
        private float stamina;
        private float longShots;
        private float marking;
        private float penalties;

        public long Index { get { return index; } set { index = value; } }
        public string Id { get { return id; } set { id = value; } }
        public string Position { get { return position; } set { position = value; } }
        public float Finishing { get { return finishing; } set { finishing = value; } }
        public float HeadingAccuracy { get { return headingAccuracy; } set { headingAccuracy = value; } }
        public float ShortPassing { get { return shortPassing; } set { shortPassing = value; } }
        public float Dribbling { get { return dribbling; } set { dribbling = value; } }
        public float FkAccuracy { get { return fkAccuracy; } set { fkAccuracy = value; } }
        public float LongPassing { get { return longPassing; } set { longPassing = value; } }
        public float Acceleration { get { return acceleration; } set { acceleration = value; } }
        public float Reactions { get { return reactions; } set { reactions = value; } }
        public float Stamina { get { return stamina; } set { stamina = value; } }
        public float LongShots { get { return longShots; } set { longShots = value; } }
        public float Marking { get { return marking; } set { marking = value; } }
        public float Penalties { get { return penalties; } set { penalties = value; } }

    }
}