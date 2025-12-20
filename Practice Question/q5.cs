//  Math ≥ 65, Phys ≥ 55, Chem ≥ 50 AND (Total ≥ 180 OR Math+Phys ≥ 140).


public class Question5{

    public static bool IsEligible(int Mmarks, int Pmarks, int Cmarks){
        
        int sum = Mmarks + Pmarks + Cmarks ;
        if( (Mmarks>= 65 && Pmarks >= 55 && Cmarks>= 50) && (sum >= 180 || Mmarks >= 140)){
            return true;
        }
        else{
            return false;
        }
    }
}