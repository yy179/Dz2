using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
namespace Dz_8;
internal class Program
{
    public static void Main(string[] args)
    {
        ThreadsCreate threadsCreate = new ThreadsCreate();
        ThreadsPool threadsPool = new ThreadsPool();
        ThreadsSync threadsSync = new ThreadsSync();
        ThreadsSemaphore threadsSemaphore = new ThreadsSemaphore();
    }
}