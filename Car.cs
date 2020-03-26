namespace JJSeeSharp{

class car{
farbe mColour;
brand mMarke;

seat[] mSeatArray = new seat[21];
int mSitzAnzahl;


//farbe, räder, sitze, marke

public car(farbe colour, brand marke, seat sitz, int sitzAnzahl){
    mColour = colour;
    mMarke = marke;
    for(int i = 0; i < sitzAnzahl; i++){
        mSeatArray[i] = sitz;
    
    } 
    mSitzAnzahl = sitzAnzahl;
}



public class seat{

    private bool mHeadrest = true;
    private rating mRating;
    private material mMaterial;
    private int mBelt;

    public seat(bool headrest, rating rating, material material, int belt){
    mHeadrest = headrest;
    mRating = rating;
    mMaterial = material;
    mBelt = belt;
    }

    public enum rating{
        low, medium, high, ss
    }

    public enum material{
        leather, fabric, gold
    }
    
    bool getHeadrest(){
        return mHeadrest;
    }

    void setHeadrest(bool headrest){
        mHeadrest = headrest;
    }

    rating getRating(){
        return mRating;
    }

    void setRating(rating rating){
        mRating = rating;
    }

    material getMaterial(){
        return mMaterial;
    }

    void setMaterial(material material){
        mMaterial = material;
    }

    string getBelt(){
        return mBelt + ".Gurt";   
    }

    void setBelt(int belt){
        mBelt = belt;
    }

    public override string ToString(){
        string output = "Headrest: " + mHeadrest.ToString() + ", Rating: " + mRating +  ", Material: " + mMaterial + ", Belt: " + getBelt();
        return output;
    }

    

}
public enum farbe{
    red, green, dingding, mxkaercher
}

public enum brand{
    vw, ford, audi, mx5, babawagen
}    


farbe getColour(){
    return mColour;
}

void setColour(farbe colour){
    mColour = colour;
}

brand getBrand(){
    return mMarke;
}

void setBrand(brand mAsdf){
    mMarke= mAsdf;
}



public override string ToString(){
    string output ="";
    output = output + "Colour: " + mColour + "\n"; 
    output = output + "Brand: " + mMarke + "\n";
    output = output + "Seat: " + mSeatArray[0].ToString() + "\n";
    output = output + "Seat-Amout: " + mSitzAnzahl;
    return output;
}

}


}
