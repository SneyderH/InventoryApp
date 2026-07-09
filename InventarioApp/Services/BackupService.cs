using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioApp.Services
{
    public class BackupService
    {
        private const int MaxBackups = 10;

        private static string DbPath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Inventory.db");

        private static string BackupFolder =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Backups");

        public void CreateBackup()
        {
            Directory.CreateDirectory(BackupFolder);

            var existingBackups = Directory.GetFiles(BackupFolder, "*.db")
                .Select(path => new FileInfo(path))
                .OrderBy(f => f.CreationTime)
                .ToList();

            if (existingBackups.Count >= MaxBackups)
            {
                var oldestBackup = existingBackups.First();
                oldestBackup.Delete();
            }

            string fileName = $"Inventory_backup_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.db";
            string backupPath = Path.Combine(BackupFolder, fileName);

            if (File.Exists(DbPath))
            {
                File.Copy(DbPath, backupPath, overwrite: true);
            }
        }
    }
}
