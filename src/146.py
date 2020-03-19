from collections import OrderedDict


class LRUCache:

    def __init__(self, capacity: int):
        self.dataMap = OrderedDict()
        self.MAX = capacity

    def get(self, key: int) -> int:
        if key not in self.dataMap:
            return - 1
        self.dataMap.move_to_end(key)
        return self.dataMap[key]

    def put(self, key: int, value: int) -> None:
        if key in self.dataMap:
            self.dataMap.move_to_end(key)
        self.dataMap[key] = value
        if (len(self.dataMap) > self.MAX):
            self.dataMap.popitem(last=False)


if __name__ == '__main__':
    obj = LRUCache(3)
    obj.put(1, 1)
    obj.put(2, 2)
    obj.put(3, 3)
    obj.put(4, 4)
    print(obj.get(4))
    print(obj.get(1))


# Your LRUCache object will be instantiated and called as such:
# obj = LRUCache(capacity)
# param_1 = obj.get(key)
# obj.put(key,value)
