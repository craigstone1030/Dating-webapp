﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using james.Models.DB;

namespace james.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20220822065357_event-amt-col")]
    partial class eventamtcol
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("james.Models.DB.Album", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("isPrivate")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("userId");

                    b.ToTable("albums");
                });

            modelBuilder.Entity("james.Models.DB.AlbumImage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("albumId")
                        .HasColumnType("int");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("photo")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("timestamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("id");

                    b.HasIndex("albumId");

                    b.ToTable("albumImages");
                });

            modelBuilder.Entity("james.Models.DB.Chat", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("attachment")
                        .HasColumnType("longtext");

                    b.Property<int>("chatThreadId")
                        .HasColumnType("int");

                    b.Property<string>("duration")
                        .HasColumnType("longtext");

                    b.Property<bool>("isSeen")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("message")
                        .HasColumnType("longtext");

                    b.Property<int>("messageType")
                        .HasColumnType("int");

                    b.Property<int>("senderId")
                        .HasColumnType("int");

                    b.Property<DateTime>("timestamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("id");

                    b.HasIndex("chatThreadId");

                    b.HasIndex("senderId");

                    b.ToTable("chats");
                });

            modelBuilder.Entity("james.Models.DB.ChatThread", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("additional_info")
                        .HasColumnType("longtext");

                    b.Property<string>("attachment")
                        .HasColumnType("longtext");

                    b.Property<int?>("chatId")
                        .HasColumnType("int");

                    b.Property<string>("last_message")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("last_message_timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("message_type")
                        .HasColumnType("int");

                    b.Property<int>("user1Id")
                        .HasColumnType("int");

                    b.Property<int>("user1_unread")
                        .HasColumnType("int");

                    b.Property<int>("user2Id")
                        .HasColumnType("int");

                    b.Property<int>("user2_unread")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("chatId");

                    b.HasIndex("user1Id");

                    b.HasIndex("user2Id");

                    b.ToTable("chatThreads");
                });

            modelBuilder.Entity("james.Models.DB.DDL", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("ddls");
                });

            modelBuilder.Entity("james.Models.DB.Diary", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("description")
                        .HasColumnType("longtext");

                    b.Property<string>("photo")
                        .HasColumnType("longtext");

                    b.Property<string>("title")
                        .HasColumnType("longtext");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("userId");

                    b.ToTable("diaries");
                });

            modelBuilder.Entity("james.Models.DB.Event", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("amount")
                        .HasColumnType("double");

                    b.Property<string>("description")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("endDate")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("isPublish")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("location")
                        .HasColumnType("longtext");

                    b.Property<string>("photo")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("startDate")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("title")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.ToTable("events");
                });

            modelBuilder.Entity("james.Models.DB.FirebaseToken", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("device")
                        .HasColumnType("longtext");

                    b.Property<bool>("isNotificationFlag")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("os")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("token")
                        .HasColumnType("longtext");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("userId");

                    b.ToTable("firebaseTokens");
                });

            modelBuilder.Entity("james.Models.DB.HiddenAlbum", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("albumId")
                        .HasColumnType("int");

                    b.Property<string>("code")
                        .HasColumnType("longtext");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<DateTime>("timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("albumId");

                    b.HasIndex("userId");

                    b.ToTable("hiddenAlbums");
                });

            modelBuilder.Entity("james.Models.DB.Match", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("fromUserId")
                        .HasColumnType("int");

                    b.Property<DateTime>("timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("toUserId")
                        .HasColumnType("int");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("fromUserId");

                    b.HasIndex("toUserId");

                    b.ToTable("matches");
                });

            modelBuilder.Entity("james.Models.DB.ReportUser", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("fromUserId")
                        .HasColumnType("int");

                    b.Property<string>("reason")
                        .HasColumnType("longtext");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<DateTime>("timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("toUserId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("fromUserId");

                    b.HasIndex("toUserId");

                    b.ToTable("reportUsers");
                });

            modelBuilder.Entity("james.Models.DB.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("aboutMe")
                        .HasColumnType("longtext");

                    b.Property<int?>("age")
                        .HasColumnType("int");

                    b.Property<int?>("alcoholConsumptionId")
                        .HasColumnType("int");

                    b.Property<int?>("annualIncomeId")
                        .HasColumnType("int");

                    b.Property<string>("banner")
                        .HasColumnType("longtext");

                    b.Property<int?>("childrenId")
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .HasColumnType("longtext");

                    b.Property<string>("eduction")
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<int?>("fetichesId")
                        .HasColumnType("int");

                    b.Property<int?>("gelocationBydistance")
                        .HasColumnType("int");

                    b.Property<int?>("genderId")
                        .HasColumnType("int");

                    b.Property<string>("height")
                        .HasColumnType("longtext");

                    b.Property<bool>("hideage")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("isdeleted")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime?>("lastLocTimestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("last_relationship")
                        .HasColumnType("longtext");

                    b.Property<string>("lat")
                        .HasColumnType("longtext");

                    b.Property<int>("likes")
                        .HasColumnType("int");

                    b.Property<string>("lng")
                        .HasColumnType("longtext");

                    b.Property<int?>("lookingGenderId")
                        .HasColumnType("int");

                    b.Property<int?>("myProfessionId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("longtext");

                    b.Property<string>("password")
                        .HasColumnType("longtext");

                    b.Property<string>("photo")
                        .HasColumnType("longtext");

                    b.Property<int?>("physicalTypeId")
                        .HasColumnType("int");

                    b.Property<string>("profession")
                        .HasColumnType("longtext");

                    b.Property<double>("rating")
                        .HasColumnType("double");

                    b.Property<int?>("relationshipStatusId")
                        .HasColumnType("int");

                    b.Property<int?>("religionId")
                        .HasColumnType("int");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.Property<int?>("sexualOrientationId")
                        .HasColumnType("int");

                    b.Property<int?>("signId")
                        .HasColumnType("int");

                    b.Property<int?>("smokeId")
                        .HasColumnType("int");

                    b.Property<int>("source")
                        .HasColumnType("int");

                    b.Property<string>("token")
                        .HasColumnType("longtext");

                    b.Property<string>("username")
                        .HasColumnType("longtext");

                    b.Property<int?>("vaccineId")
                        .HasColumnType("int");

                    b.Property<int>("views")
                        .HasColumnType("int");

                    b.Property<int?>("whereamiknow")
                        .HasColumnType("int");

                    b.Property<string>("zipcode")
                        .HasColumnType("longtext");

                    b.HasKey("id");

                    b.HasIndex("alcoholConsumptionId");

                    b.HasIndex("annualIncomeId");

                    b.HasIndex("childrenId");

                    b.HasIndex("fetichesId");

                    b.HasIndex("genderId");

                    b.HasIndex("lookingGenderId");

                    b.HasIndex("myProfessionId");

                    b.HasIndex("physicalTypeId");

                    b.HasIndex("relationshipStatusId");

                    b.HasIndex("religionId");

                    b.HasIndex("sexualOrientationId");

                    b.HasIndex("signId");

                    b.HasIndex("smokeId");

                    b.HasIndex("vaccineId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("james.Models.DB.UserHobby", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("hobbyId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("hobbyId");

                    b.HasIndex("userId");

                    b.ToTable("userHobbies");
                });

            modelBuilder.Entity("james.Models.DB.UserLookingRelation", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("relationId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("relationId");

                    b.HasIndex("userId");

                    b.ToTable("userLookingRelations");
                });

            modelBuilder.Entity("james.Models.DB.UserPersonality", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("personalityId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("personalityId");

                    b.HasIndex("userId");

                    b.ToTable("userPersonalities");
                });

            modelBuilder.Entity("james.Models.DB.UserQuality", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("qualityId")
                        .HasColumnType("int");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("qualityId");

                    b.HasIndex("userId");

                    b.ToTable("userQualities");
                });

            modelBuilder.Entity("james.Models.DB.UserRating", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("fromUserId")
                        .HasColumnType("int");

                    b.Property<double>("rating")
                        .HasColumnType("double");

                    b.Property<string>("review")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("toUserId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("fromUserId");

                    b.HasIndex("toUserId");

                    b.ToTable("userRatings");
                });

            modelBuilder.Entity("james.Models.DB.VerificationCode", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("code")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("timestamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("userId");

                    b.ToTable("verificationCodes");
                });

            modelBuilder.Entity("james.Models.DB.Album", b =>
                {
                    b.HasOne("james.Models.DB.User", "user")
                        .WithMany("albums")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("james.Models.DB.AlbumImage", b =>
                {
                    b.HasOne("james.Models.DB.Album", "album")
                        .WithMany("images")
                        .HasForeignKey("albumId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("album");
                });

            modelBuilder.Entity("james.Models.DB.Chat", b =>
                {
                    b.HasOne("james.Models.DB.ChatThread", "chatThread")
                        .WithMany()
                        .HasForeignKey("chatThreadId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("james.Models.DB.User", "sender")
                        .WithMany()
                        .HasForeignKey("senderId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("chatThread");

                    b.Navigation("sender");
                });

            modelBuilder.Entity("james.Models.DB.ChatThread", b =>
                {
                    b.HasOne("james.Models.DB.Chat", "chat")
                        .WithMany()
                        .HasForeignKey("chatId");

                    b.HasOne("james.Models.DB.User", "user1")
                        .WithMany()
                        .HasForeignKey("user1Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("james.Models.DB.User", "user2")
                        .WithMany()
                        .HasForeignKey("user2Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("chat");

                    b.Navigation("user1");

                    b.Navigation("user2");
                });

            modelBuilder.Entity("james.Models.DB.Diary", b =>
                {
                    b.HasOne("james.Models.DB.User", "user")
                        .WithMany("diaries")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("james.Models.DB.FirebaseToken", b =>
                {
                    b.HasOne("james.Models.DB.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("james.Models.DB.HiddenAlbum", b =>
                {
                    b.HasOne("james.Models.DB.Album", "album")
                        .WithMany("access")
                        .HasForeignKey("albumId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("james.Models.DB.User", "user")
                        .WithMany()
                        .HasForeignKey("userId");

                    b.Navigation("album");

                    b.Navigation("user");
                });

            modelBuilder.Entity("james.Models.DB.Match", b =>
                {
                    b.HasOne("james.Models.DB.User", "fromUser")
                        .WithMany()
                        .HasForeignKey("fromUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("james.Models.DB.User", "toUser")
                        .WithMany()
                        .HasForeignKey("toUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("fromUser");

                    b.Navigation("toUser");
                });

            modelBuilder.Entity("james.Models.DB.ReportUser", b =>
                {
                    b.HasOne("james.Models.DB.User", "fromUser")
                        .WithMany()
                        .HasForeignKey("fromUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("james.Models.DB.User", "toUser")
                        .WithMany()
                        .HasForeignKey("toUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("fromUser");

                    b.Navigation("toUser");
                });

            modelBuilder.Entity("james.Models.DB.User", b =>
                {
                    b.HasOne("james.Models.DB.DDL", "alcoholConsumption")
                        .WithMany()
                        .HasForeignKey("alcoholConsumptionId");

                    b.HasOne("james.Models.DB.DDL", "annualIncome")
                        .WithMany()
                        .HasForeignKey("annualIncomeId");

                    b.HasOne("james.Models.DB.DDL", "children")
                        .WithMany()
                        .HasForeignKey("childrenId");

                    b.HasOne("james.Models.DB.DDL", "fetiches")
                        .WithMany()
                        .HasForeignKey("fetichesId");

                    b.HasOne("james.Models.DB.DDL", "gender")
                        .WithMany()
                        .HasForeignKey("genderId");

                    b.HasOne("james.Models.DB.DDL", "lookingGender")
                        .WithMany()
                        .HasForeignKey("lookingGenderId");

                    b.HasOne("james.Models.DB.DDL", "myProfession")
                        .WithMany()
                        .HasForeignKey("myProfessionId");

                    b.HasOne("james.Models.DB.DDL", "physicalType")
                        .WithMany()
                        .HasForeignKey("physicalTypeId");

                    b.HasOne("james.Models.DB.DDL", "relationshipStatus")
                        .WithMany()
                        .HasForeignKey("relationshipStatusId");

                    b.HasOne("james.Models.DB.DDL", "religion")
                        .WithMany()
                        .HasForeignKey("religionId");

                    b.HasOne("james.Models.DB.DDL", "sexualOrientation")
                        .WithMany()
                        .HasForeignKey("sexualOrientationId");

                    b.HasOne("james.Models.DB.DDL", "sign")
                        .WithMany()
                        .HasForeignKey("signId");

                    b.HasOne("james.Models.DB.DDL", "smoke")
                        .WithMany()
                        .HasForeignKey("smokeId");

                    b.HasOne("james.Models.DB.DDL", "vaccine")
                        .WithMany()
                        .HasForeignKey("vaccineId");

                    b.Navigation("alcoholConsumption");

                    b.Navigation("annualIncome");

                    b.Navigation("children");

                    b.Navigation("fetiches");

                    b.Navigation("gender");

                    b.Navigation("lookingGender");

                    b.Navigation("myProfession");

                    b.Navigation("physicalType");

                    b.Navigation("relationshipStatus");

                    b.Navigation("religion");

                    b.Navigation("sexualOrientation");

                    b.Navigation("sign");

                    b.Navigation("smoke");

                    b.Navigation("vaccine");
                });

            modelBuilder.Entity("james.Models.DB.UserHobby", b =>
                {
                    b.HasOne("james.Models.DB.DDL", "hobby")
                        .WithMany()
                        .HasForeignKey("hobbyId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("james.Models.DB.User", "user")
                        .WithMany("hobbies")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("hobby");

                    b.Navigation("user");
                });

            modelBuilder.Entity("james.Models.DB.UserLookingRelation", b =>
                {
                    b.HasOne("james.Models.DB.DDL", "relation")
                        .WithMany()
                        .HasForeignKey("relationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("james.Models.DB.User", "user")
                        .WithMany("lookingRelations")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("relation");

                    b.Navigation("user");
                });

            modelBuilder.Entity("james.Models.DB.UserPersonality", b =>
                {
                    b.HasOne("james.Models.DB.DDL", "personality")
                        .WithMany()
                        .HasForeignKey("personalityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("james.Models.DB.User", "user")
                        .WithMany("personalities")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("personality");

                    b.Navigation("user");
                });

            modelBuilder.Entity("james.Models.DB.UserQuality", b =>
                {
                    b.HasOne("james.Models.DB.DDL", "quality")
                        .WithMany()
                        .HasForeignKey("qualityId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("james.Models.DB.User", "user")
                        .WithMany("qualities")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("quality");

                    b.Navigation("user");
                });

            modelBuilder.Entity("james.Models.DB.UserRating", b =>
                {
                    b.HasOne("james.Models.DB.User", "fromUser")
                        .WithMany()
                        .HasForeignKey("fromUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("james.Models.DB.User", "toUser")
                        .WithMany("ratings")
                        .HasForeignKey("toUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("fromUser");

                    b.Navigation("toUser");
                });

            modelBuilder.Entity("james.Models.DB.VerificationCode", b =>
                {
                    b.HasOne("james.Models.DB.User", "user")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("james.Models.DB.Album", b =>
                {
                    b.Navigation("access");

                    b.Navigation("images");
                });

            modelBuilder.Entity("james.Models.DB.User", b =>
                {
                    b.Navigation("albums");

                    b.Navigation("diaries");

                    b.Navigation("hobbies");

                    b.Navigation("lookingRelations");

                    b.Navigation("personalities");

                    b.Navigation("qualities");

                    b.Navigation("ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
