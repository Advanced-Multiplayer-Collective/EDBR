// Script to ignore all biped tags during porting  
using TagTool.Cache;  
using TagTool.Porting;  
using System.Linq;  
  
// Get the current porting context (it's a property of the script context)  
if (PortingContext != null)  
{  
    // Find all biped tags (group tag: bipd)  
    var bipedTags = PortingContext.BlamCache.TagCache.FindAllInGroup("weap");  
      
    int ignoredCount = 0;  
    foreach (var tag in bipedTags)  
    {  
        if (tag != null)  
        {  
            PortingContext.IgnoreBlamTags.Add(tag.Index);  
            ignoredCount++;  
        }  
    }  
      
    Console.WriteLine($"Added {ignoredCount} weap tags to ignore list.");  
}  
else  
{  
    Console.WriteLine("Error: PortingContext not found. Make sure you're in a porting context.");  
}