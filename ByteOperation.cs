namespace PIMUX {

    class ByteOperation {

        // Increment a byte. This is used for the nonce.
        public static void Increment(ref byte[] byteArr) {
            for (int i = 0; i < byteArr.Length; i++) {
                byteArr[i]++;
                if (byteArr[i] > 0) {
                    return;
                }
            }
            return;
        }

        // Decrement a byte.
        public static void Decrement(ref byte[] byteArr) {
            for (int i = 0; i < byteArr.Length; i++) {
                byteArr[i]--;
                if (byteArr[i] < 255) {
                    return;
                }
            }
            return;
        }




    }
}
