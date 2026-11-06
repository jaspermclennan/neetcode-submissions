class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        # 1. Create a dictionary to hold the groups
        buckets = {} 

        for s in strs:
            key = "".join(sorted(s))

            if key in buckets:
                buckets[key].append(s)
            else:
                buckets[key] = [s]

        return list(buckets.values())


    

            

