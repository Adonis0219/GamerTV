using iterator;
using UnityEngine;

public static class EnemyIteratorExtension
{
    public static Iterator DistanceFilter(this Iterator iterator, Vector3 playerPos, float minDist)
    {
        return new DistanceFilterIterator(iterator, playerPos, minDist);
    }

    public static Iterator LowHpSort(this Iterator iterator, int enemyCount)
    {
        return new LowHpSortIterator(iterator, enemyCount);
    }

    public static Iterator DistanceSort(this Iterator iterator, Vector3 playerPos)
    {
        return new DistanceSortIterator(iterator, playerPos);
    }
}
