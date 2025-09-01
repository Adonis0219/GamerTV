using UnityEngine;

public class Designer : Worker
{
    protected override void GetDressed()
    {
        Debug.Log("Ã¼Å© ¼ÅÃ÷ ÀÔ±â");
    }

    protected override void Commute()
    {
        Debug.Log("ÁöÇÏÃ¶·Î Ãâ±Ù");
    }
    
    protected override void EatBreakfast()
    {
        base.EatBreakfast();
        
        Debug.Log("»ø·¯µå ¸Ô±â");
    }
}
