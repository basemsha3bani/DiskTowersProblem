using DiskTower.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace DiskTower.Domain
{
  public  class DiskTower: GnericEntity
    {

        internal List<Disk> disks { get; set; }

        internal int numberOfDisks { get; set; }
    }
}
