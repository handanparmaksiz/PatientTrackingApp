using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientTrackingApp
{
    public static class VeritabaniHelper
    {
        private static string connectionString = "Data Source=HastaTakip.db;Version=3;";

        public static void HastaSil(int hastaId)
        {
            using (var conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                // Önce günlük verileri sil
                string silGunluk = "DELETE FROM GunlukVeri WHERE HastaId = @id";
                using (var cmd = new SQLiteCommand(silGunluk, conn))
                {
                    cmd.Parameters.AddWithValue("@id", hastaId);
                    cmd.ExecuteNonQuery();
                }

                // Sonra hastayı sil
                string silHasta = "DELETE FROM Hasta WHERE Id = @id";
                using (var cmd = new SQLiteCommand(silHasta, conn))
                {
                    cmd.Parameters.AddWithValue("@id", hastaId);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }
    }
}