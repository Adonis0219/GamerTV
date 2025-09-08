namespace iterator
{
    public interface Iterator
    {
        object Current { get; } // 현재 반환할 대상
        bool MoveNext();        // 다음 반환할 대상이 있는지 확인
        void Reset();           // 반환할 대상 인덱스 초기화
    }
}