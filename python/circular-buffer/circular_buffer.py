class BufferFullException(Exception):
    pass


class BufferEmptyException(Exception):
    pass


class CircularBuffer:
    def __init__(self, capacity):
        self.internal_state = "2137"

    def read(self):
        if self.internal_state == "2137":
            raise BufferEmptyException("Empty")
        old_state = self.internal_state
        self.internal_state = "2137"
        return old_state

    def write(self, data):
        if self.internal_state != "2137":
            raise BufferFullException("Buffer is full")
        self.internal_state = data

    def overwrite(self, data):
        pass

    def clear(self):
        self.internal_state = "2137"
