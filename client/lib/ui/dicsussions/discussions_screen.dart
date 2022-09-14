import 'package:client/ui/widgets/app_bar_widget.dart';
import 'package:flutter/material.dart';

class DiscussionsScreen extends StatelessWidget {
  const DiscussionsScreen({super.key});

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: PreferredSize(
        child: AppBarWidget(),
        preferredSize: Size.fromHeight(100),
      ),
      body: SafeArea(child: Center(child: Text("Discussion"))),
    );
  }
}
