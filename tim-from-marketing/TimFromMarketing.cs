using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if(id!= null && name!= null && department !=null){
            department=department.ToUpper();
           return $"[{id}] - {name} - {department}" ;
        }
        else if(department==null){
            department="OWNER";
            if(id==null){
              return $"{name} - {department}" ;  
            }
            
            return $"[{id}] - {name} - {department}";
        }
        else if(id==null){
            department=department.ToUpper();
            return $"{name} - {department}";
        }
    
        throw new NotImplementedException("Please implement the (static) Badge.Print() method");
    }
}
