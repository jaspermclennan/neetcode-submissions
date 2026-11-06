class Solution:
    def isAnagram(self, s: str, t: str) -> bool:

        if len(s) != len(t):
            return False
        if set(s) != set(t):
            return False

        s_dict = {}
        t_dict = {}

        for x in s:
            if x not in s_dict:
                s_dict[x] = 1
            else:
                s_dict[x] += 1
            
        for y in t:
            if y not in t_dict:
                t_dict[y] = 1
            else:
                t_dict[y] += 1

        if t_dict != s_dict:
            return False

        return True

        

        