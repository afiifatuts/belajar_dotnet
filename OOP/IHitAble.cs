namespace FundamentalUpskilling;

/*
Naming convention interface di C# diawali dengan huruf I
sebelum nama interface

*/

public interface IHitAble
{
    void GetHit(int demage);
    void Attack(IHitAble hitAble);
}