using System;
using System.Collections.Generic;

public static class DialingCodes
{
    public static Dictionary<int, string> GetEmptyDictionary()
    {
        var dict = new Dictionary<int,string>();
        return dict;
        throw new NotImplementedException($"Please implement the (static) GetEmptyDictionary() method");
    }

    public static Dictionary<int, string> GetExistingDictionary()
    {
    var prePopulated = new Dictionary<int,string>{
        {1,"United States of America"},
        {55,"Brazil"},
        {91,"India"}
    };
        return prePopulated;
    }

    public static Dictionary<int, string> AddCountryToEmptyDictionary(int countryCode, string countryName)
    {
        var countryCodes=new Dictionary<int,string>();
        countryCodes[countryCode]=countryName;
        return countryCodes;
    }

    public static Dictionary<int, string> AddCountryToExistingDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        Dictionary<int, string> countryCodes = GetExistingDictionary();
        countryCodes[countryCode]=countryName;
        return countryCodes;
    }

    public static string GetCountryNameFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
       
        if(existingDictionary.ContainsKey(countryCode)){
            return existingDictionary[countryCode];
        }
        return string.Empty;
        throw new NotImplementedException($"Please implement the (static) GetCountryNameFromDictionary() method");
    }

    public static bool CheckCodeExists(Dictionary<int, string> existingDictionary, int countryCode)
    {
        return existingDictionary.ContainsKey(countryCode);
        throw new NotImplementedException($"Please implement the (static) CheckCodeExists() method");
    }

    public static Dictionary<int, string> UpdateDictionary(
        Dictionary<int, string> existingDictionary, int countryCode, string countryName)
    {
        if(existingDictionary.ContainsKey(countryCode)){
        existingDictionary[countryCode]=countryName;
        }
        return existingDictionary;
        throw new NotImplementedException($"Please implement the (static) UpdateDictionary() method");
    }

    public static Dictionary<int, string> RemoveCountryFromDictionary(
        Dictionary<int, string> existingDictionary, int countryCode)
    {
        if(existingDictionary.ContainsKey(countryCode)){
            existingDictionary.Remove(countryCode);
        }
        return existingDictionary;
        throw new NotImplementedException($"Please implement the (static) RemoveCountryFromDictionary() method");
    }

    public static string FindLongestCountryName(Dictionary<int, string> existingDictionary)
    {
        string lcn="";
        foreach(var countryname in existingDictionary.Values){
            if (countryname.Length>lcn.Length){
                lcn=countryname;
            }
        }
        return lcn;
        
        throw new NotImplementedException($"Please implement the (static) FindLongestCountryName() method");
    }
}