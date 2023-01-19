

public class Vettore 
{

    private int[] vettore;
    private int idx=0;

    public Vettore () 
    {
        vettore = new int[1];
        vettore[0]=0;
    }

    public Vettore (int N) 
    {
        if(N<0)
        {
            vettore=new int [0];
        }
        else
        {
            vettore = new int[N];
        }
        
    }

    public bool Aggiungi(int val)
    {
        if(vettore.Length <= idx)
        {
            return false;
        }
        

        vettore[idx]=val;
        idx++;

        return true;
    }

    public int Somma()
    {
        int retVal=0;
        for(int i=0; i<vettore.Length ; i++)
            retVal +=vettore[i];

        return retVal;
    }

    public int Ultimo()
    {
        if(vettore.Length==0)
        {
            return 0;
        }


        if(idx == 0)
            return vettore[idx];
        else
        {
            return vettore[idx-1];
        }
        
    }
}