public class fornecedor
{
    string nome;
    Int64 id;
    public void SetNome(string n)
    {
       nome =n;
    }

    public void setid(Int64 i){
        id=i;
    }

    public string GetNome()
    {return nome;
    
    }

    public Int64 Getid(){
        return id;
    }
}