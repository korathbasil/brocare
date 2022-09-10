import 'package:client/app/core/colors.dart';
import 'package:client/ui/community/community_screen.dart';
import 'package:client/ui/dicsussions/discussions_screen.dart';
import 'package:client/ui/help/help_screen.dart';
import 'package:client/ui/profile/profile_screen.dart';
import 'package:flutter/material.dart';

class PrivateScreensContainer extends StatefulWidget {
  PrivateScreensContainer({super.key});

  @override
  State<PrivateScreensContainer> createState() =>
      _PrivateScreensContainerState();
}

class _PrivateScreensContainerState extends State<PrivateScreensContainer> {
  int _currentIndex = 0;

  final _pages = [
    const DiscussionsScreen(),
    const HelpScreen(),
    const CommunityScreen(),
    const ProfileScreen(),
  ];

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: _pages[_currentIndex],
      bottomNavigationBar: BottomNavigationBar(
          type: BottomNavigationBarType.fixed,
          backgroundColor: Colors.black,
          selectedItemColor: clrBlue,
          unselectedItemColor: clrgrey,
          onTap: (index) {
            setState(() {
              _currentIndex = index;
            });
          },
          currentIndex: _currentIndex,
          items: const [
            BottomNavigationBarItem(
              icon: Icon(Icons.forum),
              label: "Discussions",
            ),
            BottomNavigationBarItem(icon: Icon(Icons.help), label: "Help"),
            BottomNavigationBarItem(
                icon: Icon(Icons.people), label: "Community"),
            BottomNavigationBarItem(icon: Icon(Icons.person), label: "Profile"),
          ]),
    );
  }
}
