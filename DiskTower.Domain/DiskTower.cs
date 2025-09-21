using DiskTower.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace DiskTower.Domain
{
  public  class DiskTower
    {

        public List<Disk> disks { get; set; }

        public int numberOfDisks { get; set; }
    }
}
