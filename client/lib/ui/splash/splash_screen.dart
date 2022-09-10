import 'package:client/app/core/colors.dart';
import 'package:client/ui/login/login_screen.dart';
import 'package:flutter/material.dart';

class SplashScreen extends StatefulWidget {
  const SplashScreen({super.key});

  @override
  State<SplashScreen> createState() => _SplashScreenState();
}

class _SplashScreenState extends State<SplashScreen> {
  @override
  initState() {
    super.initState();

    Future.delayed(const Duration(milliseconds: 1500), () {
      Navigator.pushReplacement(
        context,
        MaterialPageRoute(builder: (context) => const LoginScreen()),
      );
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SafeArea(
          child: Container(
        color: clrBlack,
        padding: const EdgeInsets.all(30),
        child: Column(
          children: const [
            Expanded(
                child: Center(
              child: Logo(),
            )),
            BottomText()
          ],
        ),
      )),
    );
  }
}

class Logo extends StatelessWidget {
  const Logo({super.key});

  @override
  Widget build(BuildContext context) {
    return Row(
      mainAxisAlignment: MainAxisAlignment.center,
      children: [
        Container(
          decoration: BoxDecoration(
              color: clrBlue, borderRadius: BorderRadius.circular(10)),
          margin: const EdgeInsets.only(right: 3),
          padding: const EdgeInsets.all(3),
          child: const Text(
            "BRO",
            style: TextStyle(
                fontSize: 40, fontWeight: FontWeight.w900, color: clrBlack),
          ),
        ),
        const Text(
          "CARE",
          style: TextStyle(fontSize: 40, fontWeight: FontWeight.w900),
        )
      ],
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
            margin: const EdgeInsets.only(right: 1),
            padding: const EdgeInsets.fromLTRB(3, 1, 1, 1),
            child: const Text(
              "BRO",
              style: TextStyle(fontWeight: FontWeight.w900, color: clrBlack),
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
