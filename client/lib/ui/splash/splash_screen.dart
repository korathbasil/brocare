import 'package:flutter/material.dart';

class SplashScreen extends StatelessWidget {
  const SplashScreen({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
          child: Container(
        color: Colors.black,
        padding: EdgeInsets.all(10),
        child: Column(
          children: const [
            Expanded(
                child: Center(
              child: Text("BROCARE"),
            )),
            BottomText()
          ],
        ),
      )),
    );
  }
}

class BottomText extends StatelessWidget {
  const BottomText({super.key});

  @override
  Widget build(BuildContext context) {
    return Column(children: [
      Container(
        margin: const EdgeInsets.only(bottom: 10),
        child: const Text(
          "POWERED BY",
          style: TextStyle(fontSize: 10),
        ),
      ),
      Row(
        mainAxisAlignment: MainAxisAlignment.center,
        children: [
          Container(
            decoration: BoxDecoration(
                color: Colors.white, borderRadius: BorderRadius.circular(5)),
            padding: const EdgeInsets.fromLTRB(3, 1, 1, 1),
            child: const Text(
              "BRO",
              style:
                  TextStyle(fontWeight: FontWeight.w900, color: Colors.black),
            ),
          ),
          const Text(
            "TOTYPE",
          )
        ],
      )
    ]);
  }
}
