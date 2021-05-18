class Node:
    def __init__(self, value):
        self.value = value
        self.next = None 

    def value(self):
        return self.v

    def next(self):
        return self.n

class LinkedList:
    def __init__(self, values=[]):
        self.h = None 
        for value in values:
            self.push(value)

    def __len__(self):
        length = 0
        node = self.h
        while node:
            length += 1
            node = node.next()
        return length

    def head(self):
        if self.h is None:
            raise EmptyListException("Empty list")

        return self.h

    def push(self, value):
        node = Node(value)
        node.n = self.h 

    def pop(self):
        result = self.head().v
        self.h = self.h.n
        return result

    def reversed(self):
        pass


class EmptyListException(Exception):
    pass
