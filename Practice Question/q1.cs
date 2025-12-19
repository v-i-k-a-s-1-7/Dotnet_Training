using System;


//  Accept height in cm. If < 150 (Dwarf), 150-165 (Average), 165-190 (Tall), >190 (Abnormal).
public class Question1{

    public static string Height_Feed(int height){
        // int? height = int.Parse(Console.ReadLines());

        if (height < 150) return "Dwarf";
        else if (height >= 150 && height < 165) return "Average";
        else if (height >= 165 && height < 190) return "Tall";
        else return "Abnormal";

    }
}