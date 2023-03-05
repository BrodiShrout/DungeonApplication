using LibarayOfDoom;
using LibraryOfDoom;

namespace DungeonTests
{
    public class DungeonTests
    {
        [Fact]
        public void TestVampireBlock()
        {
            //Arrange
            NewBornVampire nb = new NewBornVampire("paul", 17, 10, 6, 5, 1, "BBBOOOOBB", WeaponTypes.Knife, false);
            int expectedBlock = 0;
            int actualBlock = 0;

            //Act
            expectedBlock = 6;
            actualBlock = nb.CalcBlock();

            //Assert
            Assert.Equal(expectedBlock, actualBlock);



        }

        [Fact]
        public void TestGorgonHit() 
        {
            Gorgon m1 = new("Medusa", hitChance: 15, block: 6, maxLife: 30, maxDamage: 5, minDamage: 1, description: "A green slithering mess of hair who was thought to have been slain by Perseus, back from the dead.", isScaly: true, weaponDrop: WeaponTypes.Madusas_Head);
            int expectedHit = 0;
            int actualHit = 0;

            //Act
            expectedHit = 9;
            actualHit = m1.CalcBlock();

            //Assert
            Assert.Equal(expectedHit, actualHit);

        }

        [Fact]
        public void TestKitsunaDamage()
        {
            Kitsuna m9 = new("The Great Kitsuna Spirit", hitChance: 40, block: 26, maxLife: 50, maxDamage: 20, minDamage: 11, description: "The Great Kistuna is a sly and fast spirit. Good luck catching her.", isWondering: true, weaponDrop: WeaponTypes.Kunai);
            int expectedDamage = 0;
            int actualDamage = 0;

            //Act
            expectedDamage = 39;
            actualDamage = m9.CalcDamage();

            //Assert
            Assert.Equal(expectedDamage, actualDamage);

        }

        [Fact]
        public void TestDemonBlock()
        {
            Demon m5 = new("Dark Knight", hitChance: 33, block: 18, maxLife: 46, maxDamage: 16, minDamage: 7, description: "A knight that lerks in the shadows. He is clad in pitch black armor, you can see his red eyes shining through the thin slits in his helmet", isDocile: true, weaponDrop: WeaponTypes.Great_Sword);
            int expectedBlock = 0;
            int actualBlock = 0;

            //Act
            expectedBlock = 27;
            actualBlock = m5.CalcBlock();

            //Assert
            Assert.Equal(expectedBlock, actualBlock);
        }

        [Fact]
        public void TestHitAncientVamp()
        {
            AncientVampire m3 = new("Darth-Dracula", hitChance: 23, block: 14, maxLife: 40, maxDamage: 14, minDamage: 6, description: "As the leader of the vampires everyone listens and bows to him. Hes an ancient vampire.", novVamp: true, weaponDrop: WeaponTypes.Darth_Blade);
            int expectedHit = 0;
            int actualHit = 0;

            //Act
            expectedHit = 21;
            actualHit = m3.CalcBlock();

            //Assert
            Assert.Equal(expectedHit, actualHit);
        }
    }
}