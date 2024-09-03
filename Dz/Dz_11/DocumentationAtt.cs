using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dz_11;
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false)]
public class DocumentationAttribute : Attribute
{
    public string Author { get; }
    public int Version { get; }
    public string Description { get; }
    public DocumentationAttribute(string author, int version)
    {  Author = author; Version = version; }
    public DocumentationAttribute(string author, int version, string description) 
    { Author = author; Version = version; Description = description; }
}
