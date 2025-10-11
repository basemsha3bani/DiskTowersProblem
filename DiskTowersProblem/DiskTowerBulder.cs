using DiskTower.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DiskTowersProblem
{

    public class DiskTowerBulder


    {
        public DiskTowerBulder()
        {
        }
        private bool invalid;

        public int numberOfDisks { get; set; }

        public List<int> diskSizes { get; set; }

        public string ErrorMessage { get; set; }


        public List<string> buildTower()
        {
            if (!this.validate())
            {
                throw new Exception(ErrorMessage);
            }
            List<string> towerBlocks = new List<string>();

            List<Disk> DiskTower = diskSizes.Select(s => new Disk { size = s, printed = false }).ToList();
            List<int> diskSet = new List<int>();
            for (int i = 0; i < DiskTower.Count; i++)
            {
                Disk disk = DiskTower.ElementAt(i);


                bool printEmptyLiine = DiskTower.Any(a => a.size > disk.size && !a.printed);
                List<int> PrintQueue;
                if (printEmptyLiine)
                {
                    towerBlocks.Add(" ");

                    PrintQueue = DiskTower.Where(w => w.size >= disk.size && !w.printed)
                                                                .OrderByDescending(ob => ob.size)
                                                                .Select(s => s.size).ToList();
                }
                else
                {
                    PrintQueue = DiskTower.Where(w => !w.printed)
                                                               .OrderByDescending(ob => ob.size)
                                                               .Select(s => s.size).ToList();
                }
                if (PrintQueue.Any())
                    towerBlocks.Add(string.Join(" ", PrintQueue));

                diskSet.AddRange(PrintQueue);



                DiskTower = DiskTower.Select(s =>
                {
                    s.printed = diskSet.Contains(s.size);
                    return s;
                }).ToList();
            }
            return towerBlocks;

        }
        bool validate()
        {

            if (diskSizes.Count != numberOfDisks)
            {
                ErrorMessage = "number of disks does not equal" + numberOfDisks.ToString();

            }
            if (diskSizes.Any(a => a <= 0))
            {
                ErrorMessage = "some disks are of invalid size ";

            }
            return (string.IsNullOrEmpty(ErrorMessage));
        }





    }

}