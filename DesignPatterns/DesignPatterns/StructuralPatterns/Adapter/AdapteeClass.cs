using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Adapter
{
    //we have data from webservice in xml format
    public static class AdapteeClass
    {
       public const string xmls = @"<?xml version='1.0' standalone='no'?>
<root>
  <person id='1'>
  <name>Rehan</name>
  <url>http://www.technologiapk.com</url>
  </person>
  <person id='2'>
  <name>Larry Page</name>
  <url>http://www.yahoo.com</url>
  </person>
</root>";
    }
}
