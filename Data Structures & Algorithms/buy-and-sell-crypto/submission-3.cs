public class Solution {
    public int MaxProfit(int[] prices) {

        var max_profit = 0;

        for(int left_edge = 0; left_edge < prices.Length; left_edge ++){

            for(int right_edge = left_edge + 1; right_edge < prices.Length; right_edge++){


                int test_profit = prices[right_edge] - prices[left_edge];
                if(test_profit > max_profit){
                    max_profit = test_profit;
                }

            }


        }
        return max_profit;
    }
}
